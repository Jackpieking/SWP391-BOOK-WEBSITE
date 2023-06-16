using AutoMapper;
using Fizzler.Systems.HtmlAgilityPack;
using Helper;
using HtmlAgilityPack;
using Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.ComicCrawlerService;

public class TruyenQQPageHandlerService
{
    private readonly ApiCallingService _apiCallingService;
    private readonly EntityManagementService _entityManagementService;
    private readonly IMapper _mapper;
    private readonly HtmlWeb _htmlWeb;

    public TruyenQQPageHandlerService(
        ApiCallingService apiCallingService,
        EntityManagementService entityManagementService,
        IMapper mapper)
    {
        _htmlWeb = new()
        {
            AutoDetectEncoding = false,
            OverrideEncoding = Encoding.UTF8
        };

        _apiCallingService = apiCallingService;
        _entityManagementService = entityManagementService;
        _mapper = mapper;
    }

    /// <summary>
    /// Crawl all comic from website
    /// </summary>
    /// <returns></returns>
    public async Task<IList<ComicModel>> CrawlComicsAsync(int startPage, int endPage)
    {
        IList<ComicModel> comicModels = new List<ComicModel>();
        HtmlDocument htmlDocument;

        //get first 2 page url
        for (int pageNumber = startPage; pageNumber <= endPage; pageNumber++)
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
                var crawlComicModel = await GetCominInfoAsync(htmlDocument: htmlDocument);

                //remove all special letter from comic name
                var formatComicName = FormatComicName(comicName: crawlComicModel.ComicName);

                await Task.Delay(millisecondsDelay: 500);

                //update crawl comic data to database
                await UploadCrawlComicModelToDatabaseAsync(
                    crawlComicModel: crawlComicModel,
                    formatComicName: formatComicName);

                //base comic url
                var baseComicPath = Path.Combine(
                    path1: "C:",
                    path2: "Comic");

                //construct comic folder and chapter of comic folder
                ContructFolder(
                    baseComicPath: baseComicPath,
                    formatComicName: formatComicName,
                    crawlComicModel: crawlComicModel);

                //download comic avatar and chapter image to constructed folder
                await DownloadAvatarAndChapterImagesAsync(
                    baseComicPath: baseComicPath,
                    formatComicName: formatComicName,
                    crawlComicModel: crawlComicModel);
            }
        }

        return comicModels;
    }

    /// <summary>
    /// Upload crawl comic model to database
    /// </summary>
    /// <param name="crawlComicModel"></param>
    /// <param name="formatComicName"></param>
    /// <returns></returns>
    private async Task UploadCrawlComicModelToDatabaseAsync(
        CrawlComicModel crawlComicModel,
        string formatComicName)
    {
        //get comic model from crawl comic model
        var comicModel = _mapper.Map<ComicModel>(source: crawlComicModel);
        comicModel.ComicAvatar = $"{formatComicName}{Path.GetExtension(path: new Uri(crawlComicModel.ComicAvatarUrl).GetLeftPart(part: UriPartial.Path))}";

        //get list of category model from crawl comic categories
        var categoryModels = _mapper.Map<IList<CategoryModel>>(source: crawlComicModel.CrawlComicCategoryModels);

        //get list of chapter model from crawl comic chapter model
        var chapterModels = _mapper.Map<IList<ChapterModel>>(source: crawlComicModel.CrawlComicChapterModels);

        chapterModels.ForEach(action: chapterModel
            => chapterModel.ComicIdentifier = comicModel.ComicIdentifier);

        chapterModels.ForEach(action: chapterModel
            => chapterModel.ChapterImageModels.ForEach(action: chapterImageModel
                => chapterImageModel.ChapterIdentifier = chapterModel.ChapterIdentifier));

        await _entityManagementService.UploadCrawlDataToDatabaseAsync(
            crawlComicModel: comicModel,
            crawlCategoryModels: categoryModels,
            crawlChapterModels: chapterModels);
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
    /// <param name="crawlComicModel"></param>
    private static void ContructFolder(
        string baseComicPath,
        string formatComicName,
        CrawlComicModel crawlComicModel)
    {
        //create comic directory base on comic name
        var chapterDirPath = Path.Combine(
            path1: baseComicPath,
            path2: "ComicImages",
            path3: $"{formatComicName}");

        Directory.CreateDirectory(path: chapterDirPath);

        //comic chapter folder inside comic folder
        foreach (var chapter in crawlComicModel.CrawlComicChapterModels)
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
    /// <param name="crawlComicModel"></param>
    /// <returns></returns>
    private async Task DownloadAvatarAndChapterImagesAsync(
        string baseComicPath,
        string formatComicName,
        CrawlComicModel crawlComicModel)
    {
        var comicAvatarPath = Path.Combine(
            path1: baseComicPath,
            path2: "ComicAvatars",
            path3: formatComicName);

        await _apiCallingService.DownloadAndSaveImageAsync(
            imageUrl: crawlComicModel.ComicAvatarUrl,
            imagePath: comicAvatarPath,
            httpClientName: "truyenqqne");

        for (int chapterOrder = default; chapterOrder < crawlComicModel.CrawlComicChapterModels.Count; chapterOrder++)
        {
            var chapter = crawlComicModel.CrawlComicChapterModels[chapterOrder];

            for (int imageOrder = default; imageOrder < chapter.CrawlChapterImageModels.Count; imageOrder++)
            {
                var image = chapter.CrawlChapterImageModels[imageOrder];

                await _apiCallingService.DownloadAndSaveImageAsync(
                    imageUrl: image.ImageUrl,
                    imagePath: Path.Combine(
                        baseComicPath,
                        "ComicImages",
                        $"{formatComicName}",
                        $"Chap_{chapter.ChapterNumber}",
                        $"{image.ImageNumber}"),
                    httpClientName: "truyenqqne");

                await Task.Delay(millisecondsDelay: 3000);
            }
        }
    }

    /// <summary>
    /// Get a comic info
    /// </summary>
    /// <param name="htmlDocument"></param>
    /// <returns></returns>
    private async Task<CrawlComicModel> GetCominInfoAsync(HtmlDocument htmlDocument)
    {
        Console.WriteLine(value: "Creating comic object!!");

        CrawlComicModel crawlComicModel = new();

        //set comic avatar
        crawlComicModel.ComicAvatarUrl = htmlDocument
            .DocumentNode
            .QuerySelector(selector: ".book_avatar > img")
            .Attributes["src"]
            .Value;

        //set comic name
        crawlComicModel.ComicName = htmlDocument
            .DocumentNode
            .QuerySelector(selector: ".book_other > h1")
            .InnerText
            .Trim();

        Console.WriteLine(value: $"Comic name: {crawlComicModel.ComicName}");

        //set comic description
        crawlComicModel.ComicDescription = htmlDocument
            .DocumentNode
            .QuerySelector(selector: ".story-detail-info.detail-content")
            .InnerText
            .Trim();

        Console.WriteLine(value: $"Comic description: {crawlComicModel.ComicDescription}");

        //set comic publisheddate
        crawlComicModel.ComicPublishedDate = DateOnly.ParseExact(
                s: htmlDocument
                    .DocumentNode
                    .QuerySelectorAll(selector: ".works-chapter-item .time-chap")
                    .Last()
                    .InnerText
                    .Trim(),
                format: "dd/MM/yyyy");

        Console.WriteLine(value: $"Comic published date: {crawlComicModel.ComicPublishedDate}");

        //set comic status
        crawlComicModel.ComicStatus = htmlDocument
            .DocumentNode
            .QuerySelector(selector: ".list-info > .status > .col-xs-9")
            .InnerText
            .Trim();

        Console.WriteLine(value: $"Comic status: {crawlComicModel.ComicStatus}");

        //set comic categories
        crawlComicModel.CrawlComicCategoryModels = htmlDocument
            .DocumentNode
            .QuerySelectorAll(selector: ".list01 > .li03")
            .Select(selector: htmlNode => new CrawlCategoryModel
            {
                CategoryName = htmlNode.InnerText.Trim(),
            })
            .ToList();

        Console.Write(value: "Comic Tag: [ ");

        foreach (var comicTag in crawlComicModel.CrawlComicCategoryModels)
        {
            Console.Write(value: $"{comicTag.CategoryName} ");
        }

        Console.WriteLine(value: "]");

        //set comic chapters
        crawlComicModel.CrawlComicChapterModels = new List<CrawlChapterModel>();

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
            CrawlChapterModel crawlChapterModel = new();

            //set chapter number
            crawlChapterModel.ChapterNumber = surpressTextNode
                .First()
                .InnerText
                .Trim()[7..];

            Console.WriteLine(value: $"Chapter number: {crawlChapterModel.ChapterNumber}");

            //set chap unlock price
            crawlChapterModel.ChapterUnlockPrice = default;

            Console.WriteLine(value: $"Chapter price: {crawlChapterModel.ChapterUnlockPrice}");

            //set chap added date
            crawlChapterModel.AddedDate = DateOnly.ParseExact(
                                s: surpressTextNode
                                    .Last()
                                    .InnerText
                                    .Trim(),
                                format: "dd/MM/yyyy");

            Console.WriteLine(value: $"Chapter added date: {crawlChapterModel.AddedDate}");

            //set chap url
            crawlChapterModel.ChapterUrl = surpressTextNode
                .First()
                .Descendants()
                .First(predicate: node => node.Name
                    .Equals(value: "a", comparisonType: StringComparison.Ordinal))
                .Attributes["href"]
                .Value;

            //inital chapter image container
            crawlChapterModel.CrawlChapterImageModels = new List<CrawlChapterImageModel>();

            htmlDocument = _htmlWeb.Load(url: crawlChapterModel.ChapterUrl);

            var chapterImageDocuments = htmlDocument
                .DocumentNode
                .QuerySelectorAll(selector: ".page-chapter");

            chapterImageDocuments.ForEach(action: chapterImageNode =>
            {
                CrawlChapterImageModel crawlChapterImageModel = new();

                //set image number
                crawlChapterImageModel.ImageNumber = chapterImageNode.Attributes["id"].Value[5..];

                //set image url
                crawlChapterImageModel.ImageUrl = chapterImageNode
                    .Descendants()
                    .First(predicate: chapterImage
                          => !chapterImage.Name.Equals(value: "#text",
                                                    comparisonType: StringComparison.Ordinal))
                    .Attributes["src"]
                    .Value;

                //add image to chapter image container
                crawlChapterModel.CrawlChapterImageModels.Add(item: crawlChapterImageModel);
            });

            //add chapter to comic chapter conatiner
            crawlComicModel.CrawlComicChapterModels.Add(item: crawlChapterModel);

            await Task.Delay(millisecondsDelay: 3000);
        };

        return crawlComicModel;
    }
}
