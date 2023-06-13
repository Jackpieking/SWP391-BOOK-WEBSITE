using MangaCrawlerApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace MangaCrawlerApi.Controllers;

[Consumes(contentType: MediaTypeNames.Application.Json)]
[Produces(contentType: MediaTypeNames.Application.Json)]
[Route(template: "api/[controller]")]
[ApiController]
public class UpdateDB : ControllerBase
{
    private readonly UpdateCrawlDataToDatabaseService _updateCrawlDataToDatabaseService;

    public UpdateDB(UpdateCrawlDataToDatabaseService updateCrawlDataToDatabaseService)
    {
        _updateCrawlDataToDatabaseService = updateCrawlDataToDatabaseService;
    }

    [HttpPost]
    public IActionResult UpdateCrawlDataToDatabase()
    {
        return Ok();
    }
}
