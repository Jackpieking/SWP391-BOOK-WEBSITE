using AutoMapper;
using BusinessLogicLayer.Services;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Net.Mime;

namespace DataAccessLayer.Controllers;

[Consumes(contentType: MediaTypeNames.Application.Json)]
[Produces(contentType: MediaTypeNames.Application.Json)]
[Route(template: "api/[controller]")]
[ApiController]
public class ComicController : ControllerBase
{
    private readonly ComicService _comicService;
    private readonly ILogger _logger;
    private readonly IMapper _mapper;
    private readonly ReadingHistoryService _readingHistoryService;

    public ComicController(
        ComicService comicService,
        ILogger<ComicController> logger,
        IMapper mapper,
        ReadingHistoryService readingHistoryService)
    {
        _comicService = comicService;
        _logger = logger;
        _mapper = mapper;
        _readingHistoryService = readingHistoryService;
    }

    [HttpGet]
    public IActionResult GetAllComic()
    {
        try
        {
            var comicJoinComicReviewModels = _comicService
                .GetAllComicWithComicReview();

            var readingHistoryJoinChapterModels = _readingHistoryService
                .GetAllReadingHistoryWithChapter();

            ICollection<GetAllComicAction_Out_Dto> getAllComicDtos = new List<GetAllComicAction_Out_Dto>();

            foreach (var comicJoinComicReviewModel in comicJoinComicReviewModels)
            {
                var getAllComicDto = _mapper.Map<GetAllComicAction_Out_Dto>(source: comicJoinComicReviewModel);

                foreach (var readingHistoryJoinChapterModel in readingHistoryJoinChapterModels)
                {
                    if (comicJoinComicReviewModel.ComicIdentifier
                        == readingHistoryJoinChapterModel.ChapterModel.ComicIdentifier)
                    {
                        getAllComicDto.NumberOfReaderHasRead++;
                    }
                }

                getAllComicDtos.Add(item: getAllComicDto);
            }

            return Ok(value: getAllComicDtos);
        }
        catch (NpgsqlException N_e)
        {
            _logger.LogError(message: $"[{DateTime.Now}]: Error: {N_e.Message}");

            return StatusCode(statusCode: StatusCodes.Status500InternalServerError);
        }
    }
}
