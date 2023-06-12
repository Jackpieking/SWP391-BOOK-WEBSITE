using AutoMapper;
using BusinessLogicLayer.Services.EntityManagementServices;
using DTO.Outgoing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace MangaManagementAPI.Controllers;

[Consumes(contentType: MediaTypeNames.Application.Json)]
[Produces(contentType: MediaTypeNames.Application.Json)]
[Route(template: "api/[controller]")]
[ApiController]
public class ChapterImageController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly ChapterImageManagementService _chapterImageManagementService;
    private readonly ILogger<ChapterImageController> _logger;

    public ChapterImageController(
        IMapper mapper,
        ChapterImageManagementService chapterImageManagementService,
        ILogger<ChapterImageController> logger)
    {
        _mapper = mapper;
        _chapterImageManagementService = chapterImageManagementService;
        _logger = logger;
    }

    [HttpGet(template: "{chapterIdentifier:guid}")]
    public async Task<IActionResult> GetAllChapterImagesOfAChapterAsync([FromRoute] Guid chapterIdentifier)
    {
        try
        {
            var chapterImageModels = await _chapterImageManagementService
                .GetAllChapterImageOfAChapterAsync(chapterIdentifer: chapterIdentifier);

            return Equals(objA: chapterImageModels, objB: null)
                ? NotFound()
                : Ok(value: _mapper
                    .Map<IEnumerable<GetAllChapterImageOfAChapterAction_Out_Dto>>(source: chapterImageModels));
        }
        catch (NpgsqlException N_e)
        {
            _logger.LogError(message: $"[{DateTime.Now}]: Error: {N_e.Message}");

            return StatusCode(statusCode: StatusCodes.Status500InternalServerError);
        }
    }
}
