using AutoMapper;
using BusinessLogicLayer.Services;
using DTO.Outgoing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
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
        _logger.LogCritical(message: "Endpoint api/chapterImage/{chapterIdentifier} !!", chapterIdentifier);

        try
        {
            var chapterImageModels = await _entityManagementService
                .GetChapterImagesWith_ImageUrlByChapterIdentifierAsync(chapterIdentifer: chapterIdentifier);

            var chapterModel = await _entityManagementService
                .GetChapterWith_ComicIdentifier_Username_UserAvatar_ChapterComment_ChapterRatingStars_ReviewTimeByChapterIdentifierAsync(chapterIdentifier: chapterIdentifier);

            var chapterModels = await _entityManagementService
                .GetAllChapterWith_ChapterIdentifier_ChapterNumberByComicNameAsync(comicName: chapterModel.ComicModel.ComicName);

            //returning dto
            var dto = _mapper.Map<GetAllChapterImageOfAChapterAction_Out_Dto>(source: chapterModel);

            //set chapter images for dto
            dto.ChapterImages = _mapper
                    .Map<IEnumerable<GetAllChapterImageOfAChapterAction_Out_Dto.ChapterImageDto>>(source: chapterImageModels);

            //set the first chapter identifier
            dto.FirstChapterIdentifier = chapterModels[0].ChapterIdentifier;

            //set the last chapter identifier
            dto.LastChapterIdentifier = chapterModels[chapterModels.Count - 1].ChapterIdentifier;

            if (chapterModels.Count == 1)
            {
                dto.NextChapterIdentifier = Guid.Empty;
                dto.PreviousChapterIdentifier = Guid.Empty;

                return Ok(value: dto);
            }

            //if current chap is the first chap
            if (chapterModels[0].ChapterIdentifier.Equals(g: dto.ChapterIdentifier))
            {
                dto.NextChapterIdentifier = chapterModels[1].ChapterIdentifier;

                dto.PreviousChapterIdentifier = Guid.Empty;

                return Ok(value: dto);
            }

            //if current chap is the last chap
            if (chapterModels[chapterModels.Count - 1].ChapterIdentifier.Equals(g: dto.ChapterIdentifier))
            {
                dto.PreviousChapterIdentifier = chapterModels
                    .Skip(count: chapterModels.Count - 2)
                    .Take(count: 1)
                    .First()
                    .ChapterIdentifier;

                dto.NextChapterIdentifier = Guid.Empty;

                return Ok(value: dto);
            }

            //if current chap is in range of available chap
            for (int chapterOrder = 0; chapterOrder < chapterModels.Count; chapterOrder++)
            {
                var chapter = chapterModels[chapterOrder];

                if (dto.ChapterIdentifier.Equals(g: chapter.ChapterIdentifier))
                {
                    dto.PreviousChapterIdentifier = chapterModels[chapterOrder - 1].ChapterIdentifier;
                    dto.NextChapterIdentifier = chapterModels[chapterOrder + 1].ChapterIdentifier;

                    break;
                }
            }

            return Ok(value: dto);
        }
        catch (NpgsqlException N_e)
        {
            _logger.LogError(message: $"[{DateTime.Now}]: Error: {N_e.Message}");

            return StatusCode(statusCode: StatusCodes.Status500InternalServerError);
        }
    }
}
