using AutoMapper;
using BusinessLogicLayer.Services;
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
    private readonly EntityManagementService _entityManagementService;
    private readonly IMapper _mapper;
    private readonly ILogger<ChapterImageController> _logger;

    public ChapterImageController(
        EntityManagementService entityManagementService,
        IMapper mapper,
        ILogger<ChapterImageController> logger)
    {
        _entityManagementService = entityManagementService;
        _mapper = mapper;
        _logger = logger;
    }

    [HttpGet(template: "{chapterIdentifier:guid}")]
    public async Task<IActionResult> GetAllChapterImagesOfAChapterAsync([FromRoute] Guid chapterIdentifier)
    {
        try
        {
            var chapterImageModels = await _entityManagementService
                .GetAllChapterImagesOfAChapterByChapterIdentifierAsync(chapterIdentifer: chapterIdentifier);

            var chapterModel = await _entityManagementService
                .GetAChapterWithComicAndChapterReviewListByChapterIdentifierAsync(chapterIdentifier: chapterIdentifier);

            GetAllChapterImageOfAChapterAction_Out_Dto allChapterImageAndChapterInfoOfAChapterDto = new()
            {
                ComicName = chapterModel.ComicModel.ComicName,
                ChapterNumber = chapterModel.ChapterNumber,
                ChapterIdentifier = chapterIdentifier,
                ChapterImages = _mapper
                    .Map<IEnumerable<GetAllChapterImageOfAChapterAction_Out_Dto.ChapterImageDto>>(source: chapterImageModels),
                ChapterReviews = _mapper
                    .Map<IEnumerable<GetAllChapterImageOfAChapterAction_Out_Dto.ReviewChapterDto>>(source: chapterModel.ReviewChapterModels)
            };

            return Ok(value: allChapterImageAndChapterInfoOfAChapterDto);
        }
        catch (NpgsqlException N_e)
        {
            _logger.LogError(message: $"[{DateTime.Now}]: Error: {N_e.Message}");

            return StatusCode(statusCode: StatusCodes.Status500InternalServerError);
        }
    }
}
