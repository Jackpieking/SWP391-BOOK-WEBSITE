using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using MangaCrawlerApi.Data.Models;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MangaCrawlerApi.Services;

public class TruyenQQPageHandlerService
{
    private readonly HtmlWeb _htmlWeb;
    private const string BaseUrl = "https://truyenqqne.com/truyen-moi-cap-nhat/trang-1.html";

    public TruyenQQPageHandlerService()
    {
        _htmlWeb = new()
        {
            AutoDetectEncoding = false,
            OverrideEncoding = System.Text.Encoding.UTF8
        };
    }

    public async Task ParsePageAndGetAllComicOfPage()
    {
        var htmlDocument = await _htmlWeb.LoadFromWebAsync(url: BaseUrl);

        var htmlNodes = htmlDocument
            .DocumentNode
            .QuerySelectorAll(selector: ".page_redirect > a");

        var lastPageNumber = short.Parse(s: htmlNodes
            .Last()
            .Attributes["href"]
            .Value
            .Split(separator: "/")
            .Last()
            .Substring(startIndex: 6, length: 3));

        for (int pageNumber = 1; pageNumber <= lastPageNumber; pageNumber++)
        {
            var pageUrl = $"https://truyenqqne.com/truyen-moi-cap-nhat/trang-{pageNumber}.html";

            htmlDocument = await _htmlWeb.LoadFromWebAsync(url: pageUrl);

            foreach (var comic in htmlDocument.DocumentNode.QuerySelectorAll(selector: ".book_avatar > a"))
            {
                await GetCominInfo(comicUrl: comic.Attributes["href"].Value);
                await Task.Delay(millisecondsDelay: 700);
            }
        }
    }

    private async Task GetCominInfo(string comicUrl)
    {
        var htmlDocument = await _htmlWeb.LoadFromWebAsync(url: comicUrl);

        Comic comic = new()
        {
            ComicTitle = htmlDocument.DocumentNode.QuerySelector(selector: ".book_other > h1").InnerText.Trim(),
            ComicDescription = htmlDocument.DocumentNode.QuerySelector(selector: ".story-detail-info.detail-content").InnerText.Trim(),
            ComicLatestChapter = ushort.Parse(s: htmlDocument.DocumentNode.QuerySelector(selector: ".works-chapter-item a").InnerText.Substring(7, 2).Trim()),
            ComicPublishedDate = DateOnly.ParseExact(s: htmlDocument.DocumentNode.QuerySelector(selector: ".works-chapter-item .time-chap").InnerText.Trim(), format: "dd/MM/yyyy"),
            ComicPublisher = htmlDocument.DocumentNode.QuerySelector(selector: ".org").InnerText.Trim(),
            ComicStatus = htmlDocument.DocumentNode.QuerySelector(selector: ".list-info > .status > .col-xs-9").InnerText.Trim(),
            ComicTags = htmlDocument.DocumentNode.QuerySelectorAll(selector: ".list01 > .li03").Select(selector: htmlNode => htmlNode.InnerText)
        };

        Console.WriteLine(JsonConvert.SerializeObject(value: comic, formatting: Formatting.Indented));
    }
}
