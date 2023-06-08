using BusinessLogicLayer.Services.Contracts;
using DataAccessLayer.DTO.Outgoing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Npgsql;
using System;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLayer.Controllers;

[Consumes(contentType: Application.Json)]
[Produces(contentType: Application.Json)]
[Route(template: "api/[controller]")]
[ApiController]
public class ComicController : ControllerBase
{
    private readonly IComicService _comicService;
    private readonly ILogger _logger;

    public ComicController(
        IComicService comicService,
        ILogger<ComicController> logger)
    {
        _comicService = comicService;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllComic()
    {
        try
        {
            var comicsAsModel = await _comicService
                .GetAllComicFromDatabaseAsync();

            return Ok(value: comicsAsModel
                .Select(comicAsModel => new GetAllComicAction_Out_Dto
                {
                    ComicIdentifier = comicAsModel.ComicIdentifier,
                    Name = comicAsModel.Name,
                    Description = comicAsModel.Description,
                    Avatar = comicAsModel.Avatar,
                    PublishDate = comicAsModel.PublishDate,
                    LatestChapter = comicAsModel.LatestChapter
                }));
        }
        catch (NpgsqlException N_e)
        {
            _logger.LogError(message: $"[{DateTime.Now}]: Error: {N_e.Message}");
            return StatusCode(statusCode: StatusCodes.Status500InternalServerError);
        }
    }
}
