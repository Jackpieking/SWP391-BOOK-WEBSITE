using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using MangaCrawlerApi.Data.Models;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MangaCrawlerApi.Services;

public class TruyenQQPageHandlerService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly HtmlWeb _htmlWeb;

    public TruyenQQPageHandlerService(IHttpClientFactory httpClientFactory)
    {
        _htmlWeb = new()
        {
            AutoDetectEncoding = false,
            OverrideEncoding = Encoding.UTF8
        };

        _httpClientFactory = httpClientFactory;
    }

    /// <summary>
    /// main entry
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task ParsePageAndGetAllComicOfPage(CancellationToken cancellationToken)
    {
        const string FirstPageUrl = "https://truyenqqne.com/truyen-moi-cap-nhat/trang-1.html";

        var htmlDocument = await _htmlWeb.LoadFromWebAsync(url: FirstPageUrl, cancellationToken: cancellationToken);

        //var lastPageNumber = short.Parse(s: htmlDocument
        //    .DocumentNode
        //    .QuerySelectorAll(selector: ".page_redirect > a")
        //    .Last()
        //    .Attributes["href"]
        //    .Value
        //    .Split(separator: "/")
        //    .Last()
        //    .Substring(startIndex: 6, length: 3));

        for (int pageNumber = 1; pageNumber <= 3; pageNumber++)
        {
            var pageUrl = $"https://truyenqqne.com/truyen-moi-cap-nhat/trang-{pageNumber}.html";

            htmlDocument = await _htmlWeb.LoadFromWebAsync(url: pageUrl, cancellationToken: cancellationToken);

            foreach (var htmlNode in htmlDocument
                .DocumentNode
                .QuerySelectorAll(selector: ".book_avatar > a"))
            {
                htmlDocument = await _htmlWeb.LoadFromWebAsync(url: htmlNode.Attributes["href"].Value, cancellationToken: cancellationToken);

                var comic = GetCominInfo(htmlDocument: htmlDocument);

                var baseComicPath = Path.Combine(
                    path1: "C:",
                    path2: "KHOA'S PERSONAL FOLDER",
                    path3: "PERSONAL FOLDER",
                    path4: "Comics");

                ContructFolder(
                    baseComicPath: baseComicPath,
                    comic: comic);

                await DownloadAvatarAndChapterImagesAsync(
                    baseComicPath: baseComicPath,
                    comic: comic,
                    htmlDocument: htmlDocument,
                    cancellationToken: cancellationToken);

                await Task.Delay(millisecondsDelay: 1000, cancellationToken: cancellationToken);
            }
        }
    }

    /// <summary>
    /// construct folder of manga inside ComicImage and ComicAvatar folder
    /// </summary>
    /// <param name="baseComicPath"></param>
    /// <param name="comic"></param>
    private static void ContructFolder(
        string baseComicPath,
        Comic comic)
    {
        var comicImageDirPath = Path.Combine(
            path1: baseComicPath,
            path2: "ComicImages",
            path3: $"{comic.ComicName}");

        Directory.CreateDirectory(path: comicImageDirPath);

        foreach (var chapter in comic.ComicChapters)
        {
            var comicChapterImageDirPath = Path.Combine(
                path1: baseComicPath,
                path2: "ComicImages",
                path3: $"{comic.ComicName}",
                path4: $"Chap_{chapter.ChapterNumber}");

            Directory.CreateDirectory(path: comicChapterImageDirPath);
        }
    }

    /// <summary>
    /// Download all manga avatar images and all chapter's images of each manga
    /// </summary>
    /// <param name="baseComicPath"></param>
    /// <param name="comic"></param>
    /// <param name="htmlDocument"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    private async Task DownloadAvatarAndChapterImagesAsync(
        string baseComicPath,
        Comic comic,
        HtmlDocument htmlDocument,
        CancellationToken cancellationToken)
    {
        var comicAvatarPath = Path.Combine(
            path1: baseComicPath,
            path2: "ComicAvatars",
            path3: $"{comic.ComicName}");

        await DownloadAndSaveImageAsync(
            imageUrl: htmlDocument
                .DocumentNode
                .QuerySelector(selector: ".book_avatar > img")
                .Attributes["src"]
                .Value,
            imagePath: comicAvatarPath,
            cancellationToken: cancellationToken);

        var chapNumber = 1;

        foreach (var chap in htmlDocument
            .DocumentNode
            .QuerySelectorAll(selector: ".name-chap > a")
            .OrderBy(keySelector: node => node.InnerText))
        {
            await DownloadImageOfChapterAsync(
                document: htmlDocument,
                comicName: comic.ComicName,
                chapUrl: chap.Attributes["href"].Value,
                chapNumber: chapNumber,
                baseComicPath: baseComicPath,
                cancellationToken: cancellationToken);

            chapNumber++;
        }
    }

    /// <summary>
    /// Download images of chapter (partial block of DownloadAvatarAndChapterImagesAsync method)
    /// </summary>
    /// <param name="document"></param>
    /// <param name="comicName"></param>
    /// <param name="chapUrl"></param>
    /// <param name="chapNumber"></param>
    /// <param name="baseComicPath"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    private async Task DownloadImageOfChapterAsync(
        HtmlDocument document,
        string comicName,
        string chapUrl,
        int chapNumber,
        string baseComicPath,
        CancellationToken cancellationToken)
    {
        document = await _htmlWeb.LoadFromWebAsync(url: chapUrl, cancellationToken: cancellationToken);

        var chapterPath = Path.Combine(
            baseComicPath,
            "ComicImages",
            $"{comicName}",
            $"Chap_{chapNumber}");

        var imageNumber = 1;

        foreach (var image in document
            .DocumentNode
            .QuerySelectorAll(selector: ".page-chapter > img"))
        {
            var imagePath = Path.Combine(
                chapterPath,
                $"{imageNumber++}");

            await DownloadAndSaveImageAsync(
                imageUrl: image.Attributes["src"].Value,
                imagePath: imagePath,
                cancellationToken: cancellationToken);

            await Task.Delay(millisecondsDelay: 1000, cancellationToken: cancellationToken);
        }
    }

    /// <summary>
    /// Get a comic info
    /// </summary>
    /// <param name="htmlDocument"></param>
    /// <returns></returns>
    private static Comic GetCominInfo(
        HtmlDocument htmlDocument)
    {
        Comic comic = new()
        {
            ComicName = htmlDocument
                .DocumentNode
                .QuerySelector(selector: ".book_other > h1")
                .InnerText
                .Trim()
                .Replace(oldValue: "\"", newValue: "")
                .Replace(oldValue: "\\", newValue: "")
                .Replace(oldValue: "//", newValue: "")
                .Replace(oldValue: ":", newValue: "")
                .Replace(oldValue: "*", newValue: "")
                .Replace(oldValue: "?", newValue: "")
                .Replace(oldValue: "<", newValue: "")
                .Replace(oldValue: ">", newValue: "")
                .Replace(oldValue: "|", newValue: "")
                .Replace(oldChar: ' ', newChar: '_'),

            ComicDescription = htmlDocument
                .DocumentNode
                .QuerySelector(selector: ".story-detail-info.detail-content")
                .InnerText
                .Trim(),

            ComicPublishedDate = DateOnly
                .ParseExact(s: htmlDocument
                .DocumentNode
                .QuerySelector(selector: ".works-chapter-item .time-chap")
                .InnerText
                .Trim(), format: "dd/MM/yyyy"),

            ComicPublisher = htmlDocument
                .DocumentNode
                .QuerySelector(selector: ".org")
                .InnerText
                .Trim(),

            ComicStatus = htmlDocument
                .DocumentNode
                .QuerySelector(selector: ".list-info > .status > .col-xs-9")
                .InnerText
                .Trim(),

            ComicTags = htmlDocument
                .DocumentNode
                .QuerySelectorAll(selector: ".list01 > .li03")
                .Select(selector: htmlNode => htmlNode.InnerText.Trim()),

            ComicChapters = htmlDocument
                .DocumentNode
                .QuerySelectorAll(selector: ".works-chapter-list > .works-chapter-item")
                .Select(selector: htmlNode =>
                {
                    var childNodes = htmlNode
                        .ChildNodes
                        .Where(predicate: node => !node.Name.Equals(
                            value: "#text",
                            comparisonType: StringComparison.Ordinal));

                    try
                    {
                        return new Chapter
                        {
                            ChapterNumber = childNodes
                                .First()
                                .InnerText
                                .Trim()
                                [7..]
                                .Replace(oldChar: ' ', newChar: '_'),

                            AddedDate = DateOnly
                                .ParseExact(
                                    s: childNodes
                                        .Last()
                                        .InnerText
                                        .Trim(),
                                    format: "dd/MM/yyyy"),

                            ChapterUnlockPrice = 0
                        };
                    }
                    catch (FormatException F_e)
                    {
                        Console.WriteLine(value: $"[Error] - [{DateTime.Now}]: {F_e.Message}");

                        return new Chapter();
                    }
                })
        };

        return comic;
    }

    /// <summary>
    /// Download an image from specific source and save to a specific path
    /// </summary>
    /// <param name="imageUrl"></param>
    /// <param name="imagePath"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    private async Task DownloadAndSaveImageAsync(
        string imageUrl,
        string imagePath,
        CancellationToken cancellationToken)
    {
        var httpclient = _httpClientFactory.CreateClient(name: "truyenqqne");

        Uri uri = new(uriString: imageUrl);
        var fileExtension = Path.GetExtension(path: uri.GetLeftPart(part: UriPartial.Path));

        await using var stream = await httpclient.GetStreamAsync(requestUri: imageUrl, cancellationToken: cancellationToken);
        await using FileStream fileStream = File.Create(path: $"{imagePath}{fileExtension}");
        await stream.CopyToAsync(destination: fileStream, cancellationToken: cancellationToken);
    }
}
