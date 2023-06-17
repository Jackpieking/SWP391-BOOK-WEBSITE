using BusinessLogicLayer.Services.ComicCrawlerService;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Threading.Tasks;

namespace MangaManagementAPI.Controllers;

[Consumes(contentType: MediaTypeNames.Application.Json)]
[Produces(contentType: MediaTypeNames.Application.Json)]
[Route(template: "api/[controller]")]
[ApiController]
public class CrawlComicController : ControllerBase
{
    private readonly TruyenQQPageHandlerService _truyenQQPageHandlerService;

    public CrawlComicController(
        TruyenQQPageHandlerService truyenQQPageHandlerService)
    {
        _truyenQQPageHandlerService = truyenQQPageHandlerService;
    }

    [HttpGet]
    public async Task<IActionResult> UpdateComicToDatabaseAsync()
    {
        await _truyenQQPageHandlerService.CrawlComicsAsync(startPage: 1, endPage: 2);

        return Ok();
    }
}
