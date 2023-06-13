using MangaCrawlerApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Mime;
using System.Threading.Tasks;

namespace MangaCrawlerApi.Controllers;

[Consumes(contentType: MediaTypeNames.Application.Json)]
[Produces(contentType: MediaTypeNames.Application.Json)]
[Route(template: "api/[controller]")]
[ApiController]
public class ComicCrawlerController : ControllerBase
{
    private readonly ILogger<ComicCrawlerController> _logger;
    private readonly TruyenQQPageHandlerService _service;

    public ComicCrawlerController(
        ILogger<ComicCrawlerController> logger,
        TruyenQQPageHandlerService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        await _service.ParsePageAndGetAllComicOfPage();

        return Ok();
    }
}
