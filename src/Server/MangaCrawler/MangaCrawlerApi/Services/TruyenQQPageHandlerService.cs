using AutoMapper;
using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using MangaCrawlerApi.Data.Models;
using MangaCrawlerApi.DTOs.Outgoing;
using MangaCrawlerApi.Helper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaCrawlerApi.Services;

public class TruyenQQPageHandlerService
{
	private readonly ApiCallingService _apiCallingService;
	private readonly IMapper _mapper;
	private readonly HtmlWeb _htmlWeb;

	public TruyenQQPageHandlerService(
		ApiCallingService apiCallingService,
		IMapper mapper)
	{
		_htmlWeb = new()
		{
			AutoDetectEncoding = false,
			OverrideEncoding = Encoding.UTF8
		};

		_apiCallingService = apiCallingService;
		_mapper = mapper;
	}

	/// <summary>
	/// main entry
	/// </summary>
	/// <returns></returns>
	public Task EntryPointAsync() => GetAllComicAsync();

	/// <summary>
	/// Crawl all comic from website
	/// </summary>
	/// <returns></returns>
	public async Task GetAllComicAsync()
	{
		HtmlDocument htmlDocument;

		//get first 2 page url
		for (int pageNumber = 1; pageNumber <= 2; pageNumber++)
		{
			var pageUrl = $"https://truyenqqne.com/truyen-moi-cap-nhat/trang-{pageNumber}.html";

			//load html of each page
			htmlDocument = _htmlWeb.Load(url: pageUrl);

			//get information of each comic of page
			foreach (var htmlNode in htmlDocument
				.DocumentNode
				.QuerySelectorAll(selector: ".book_avatar > a"))
			{
				//load html of each comic
				htmlDocument = _htmlWeb.Load(url: htmlNode.Attributes["href"].Value);

				//parse html and get a comic object
				var comic = await GetCominInfoAsync(htmlDocument: htmlDocument);

				//remove all special letter from comic name
				var formatComicName = FormatComicName(comicName: comic.ComicName);

				await Task.Delay(millisecondsDelay: 2000);

				//call api to update database
				UpdateCrawlDataToDatabaseAction_Out_Dto dto = new();

				var updateDataDto = _mapper.Map<UpdateCrawlDataToDatabaseAction_Out_Dto.ComicDtoType>(source: comic);
				updateDataDto.ComicAvatar = $"{formatComicName}{Path.GetExtension(path: new Uri(comic.ComicAvatarUrl).GetLeftPart(part: UriPartial.Path))}";

				dto.ComicDto = updateDataDto;

				await _apiCallingService.UpdateComicToDatabaseAsync(dto: dto);

				//base comic url
				var baseComicPath = Path.Combine(
					path1: "C:",
					path2: "Comic");

				//construct comic folder and chapter of comic folder
				ContructFolder(
					baseComicPath: baseComicPath,
					formatComicName: formatComicName,
					comic: comic);

				//download comic avatar and chapter image to constructed folder
				await DownloadAvatarAndChapterImagesAsync(
					baseComicPath: baseComicPath,
					formatComicName: formatComicName,
					comic: comic);
			}
		}
	}

	private static string FormatComicName(string comicName)
	{
		return comicName
			.Replace(oldValue: "\"", newValue: "")
			.Replace(oldValue: "\\", newValue: "")
			.Replace(oldValue: "//", newValue: "")
			.Replace(oldValue: ":", newValue: "")
			.Replace(oldValue: "*", newValue: "")
			.Replace(oldValue: "?", newValue: "")
			.Replace(oldValue: "<", newValue: "")
			.Replace(oldValue: ">", newValue: "")
			.Replace(oldValue: "|", newValue: "")
			.Replace(oldChar: ' ', newChar: '_');
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="baseComicPath"></param>
	/// <param name="formatComicName"></param>
	/// <param name="comic"></param>
	private static void ContructFolder(
		string baseComicPath,
		string formatComicName,
		Comic comic)
	{
		//create comic directory base on comic name
		var chapterDirPath = Path.Combine(
			path1: baseComicPath,
			path2: "ComicImages",
			path3: $"{formatComicName}");

		Directory.CreateDirectory(path: chapterDirPath);

		//comic chapter folder inside comic folder
		foreach (var chapter in comic.ComicChapters)
		{
			var chapterImageDirPath = Path.Combine(
				path1: chapterDirPath,
				path2: $"Chap_{chapter.ChapterNumber}");

			Directory.CreateDirectory(path: chapterImageDirPath);
		}
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="baseComicPath"></param>
	/// <param name="formatComicName"></param>
	/// <param name="comic"></param>
	/// <returns></returns>
	private async Task DownloadAvatarAndChapterImagesAsync(
		string baseComicPath,
		string formatComicName,
		Comic comic)
	{
		var comicAvatarPath = Path.Combine(
			path1: baseComicPath,
			path2: "ComicAvatars",
			path3: formatComicName);

		await _apiCallingService.DownloadAndSaveImageAsync(
			imageUrl: comic.ComicAvatarUrl,
			imagePath: comicAvatarPath,
			httpClientName: "truyenqqne");

		for (int chapterOrder = default; chapterOrder < comic.ComicChapters.Count; chapterOrder++)
		{
			var chapter = comic.ComicChapters[chapterOrder];

			for (int imageOrder = default; imageOrder < chapter.ChapterImages.Count; imageOrder++)
			{
				var image = chapter.ChapterImages[imageOrder];

				await _apiCallingService.DownloadAndSaveImageAsync(
					imageUrl: image.ImageUrl,
					imagePath: Path.Combine(
						baseComicPath,
						"ComicImages",
						$"{formatComicName}",
						$"Chap_{chapter.ChapterNumber}",
						$"{image.ImageNumber}"),
					httpClientName: "truyenqqne");

				await Task.Delay(millisecondsDelay: 5000);
			}
		}
	}

	/// <summary>
	/// Get a comic info
	/// </summary>
	/// <param name="htmlDocument"></param>
	/// <returns></returns>
	private async Task<Comic> GetCominInfoAsync(HtmlDocument htmlDocument)
	{
		Console.WriteLine(value: "Creating comic object!!");

		Comic comic = new();

		//set comic avatar
		comic.ComicAvatarUrl = htmlDocument
			.DocumentNode
			.QuerySelector(selector: ".book_avatar > img")
			.Attributes["src"]
			.Value;

		//set comic name
		comic.ComicName = htmlDocument
			.DocumentNode
			.QuerySelector(selector: ".book_other > h1")
			.InnerText
			.Trim();

		Console.WriteLine(value: $"Comic name: {comic.ComicName}");

		//set comic description
		comic.ComicDescription = htmlDocument
			.DocumentNode
			.QuerySelector(selector: ".story-detail-info.detail-content")
			.InnerText
			.Trim();

		Console.WriteLine(value: $"Comic description: {comic.ComicDescription}");

		//set comic publisheddate
		comic.ComicPublishedDate = DateOnly.ParseExact(
				s: htmlDocument
					.DocumentNode
					.QuerySelector(selector: ".works-chapter-item .time-chap")
					.InnerText
					.Trim(),
				format: "dd/MM/yyyy");

		Console.WriteLine(value: $"Comic published date: {comic.ComicPublishedDate}");

		//set comic status
		comic.ComicStatus = htmlDocument
			.DocumentNode
			.QuerySelector(selector: ".list-info > .status > .col-xs-9")
			.InnerText
			.Trim();

		Console.WriteLine(value: $"Comic status: {comic.ComicStatus}");

		//set comic tags
		comic.ComicCategories = htmlDocument
			.DocumentNode
			.QuerySelectorAll(selector: ".list01 > .li03")
			.Select(selector: htmlNode => new Category
			{
				CategoryName = htmlNode.InnerText.Trim(),
			})
			.ToList();

		Console.Write(value: "Comic Tag: [ ");

		foreach (var comicTag in comic.ComicCategories)
		{
			Console.Write(value: $"{comicTag.CategoryName} ");
		}

		Console.WriteLine(value: "]");

		//set comic chapters
		comic.ComicChapters = new List<Chapter>();

		//get comic chapter from web and sort them by chap number
		var crawlComicChapters = htmlDocument
			.DocumentNode
			.QuerySelectorAll(selector: ".works-chapter-item")
			.OrderBy(chap =>
			{
				return double.Parse(
					s: chap.ChildNodes
						.First(predicate: node => !node.Name.Equals(value: "#text", comparisonType: StringComparison.Ordinal))
						.InnerText
						.Trim()[7..],
					provider: CultureInfo.InvariantCulture);
			})
			.ToList();

		var crawlComicChapterCount = crawlComicChapters.Count;

		//if comic number is <= 5, get all of comic, else get only first 5 comics
		if (crawlComicChapterCount > 5)
		{
			crawlComicChapterCount = 5;
		}

		//add each image number to the container
		Console.WriteLine(value: "Comic Chapter: ");

		for (int comicOrder = 0; comicOrder < crawlComicChapterCount; comicOrder++)
		{
			//get each chapter html
			var crawlChapter = crawlComicChapters[comicOrder];

			//supress child "text" tag in dom of current chapter html
			var surpressTextNode = crawlChapter
				.ChildNodes
					.Where(predicate: node => !node.Name.Equals(
						value: "#text",
						comparisonType: StringComparison.Ordinal));

			//initial comic chapter container
			Chapter chapter = new();

			//set chap number
			chapter.ChapterNumber = surpressTextNode
				.First()
				.InnerText
				.Trim()[7..];

			Console.WriteLine(value: $"Chapter number: {chapter.ChapterNumber}");

			//set chap unlock price
			chapter.ChapterUnlockPrice = default;

			Console.WriteLine(value: $"Chapter price: {chapter.ChapterUnlockPrice}");

			//set chap added date
			chapter.AddedDate = DateOnly.ParseExact(
								s: surpressTextNode
									.Last()
									.InnerText
									.Trim(),
								format: "dd/MM/yyyy");

			Console.WriteLine(value: $"Chapter added date: {chapter.AddedDate}");

			//set chap url
			chapter.ChapterUrl = surpressTextNode
				.First()
				.Descendants()
				.First(predicate: node => node.Name
					.Equals(value: "a", comparisonType: StringComparison.Ordinal))
				.Attributes["href"]
				.Value;

			//inital chapter image container
			chapter.ChapterImages = new List<ChapterImage>();

			htmlDocument = _htmlWeb.Load(url: chapter.ChapterUrl);

			var chapterImageDocuments = htmlDocument
				.DocumentNode
				.QuerySelectorAll(selector: ".page-chapter");

			chapterImageDocuments.ForEach(action: chapterImageNode =>
			{
				ChapterImage chapterImage = new();

				//set image number
				chapterImage.ImageNumber = chapterImageNode.Attributes["id"].Value[5..];

				//set image url
				chapterImage.ImageUrl = chapterImageNode
					.Descendants()
					.First(predicate: chapterImage
						  => !chapterImage.Name.Equals(value: "#text",
													comparisonType: StringComparison.Ordinal))
					.Attributes["src"]
					.Value;

				//add image to chapter image container
				chapter.ChapterImages.Add(item: chapterImage);
			});

			//add chapter to comic chapter conatiner
			comic.ComicChapters.Add(item: chapter);

			await Task.Delay(millisecondsDelay: 5000);
		};

		return comic;
	}
}
