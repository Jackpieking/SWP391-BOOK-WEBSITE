using AutoMapper;
using BusinessLogicLayer.Services;
using DTO;
using Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;

namespace DataAccessLayer.Controllers;

[Consumes(contentType: MediaTypeNames.Application.Json)]
[Produces(contentType: MediaTypeNames.Application.Json)]
[Route(template: "api/[controller]")]
[ApiController]
public class ComicController : ControllerBase
{
    private readonly ComicService _comicService;
    private readonly ReadingHistoryService _readingHistoryService;
    private readonly ReviewComicService _reviewComicService;
    private readonly ILogger _logger;
    private readonly IMapper _mapper;

    public ComicController(
        ComicService comicService,
        ILogger<ComicController> logger,
        IMapper mapper,
        ReadingHistoryService readingHistoryService,
        ReviewComicService reviewComicService)
    {
        _comicService = comicService;
        _logger = logger;
        _mapper = mapper;
        _readingHistoryService = readingHistoryService;
        _reviewComicService = reviewComicService;
    }

    /// <summary>
    /// Return some general information about all comic
    /// </summary>
    /// <returns>[200 - 500]</returns>
    [HttpGet]
    public IActionResult GetAllComic()
    {
        try
        {
            var comicModels = _comicService
                .GetAllComic();

            var readingHistoryJoinChapterModels = _readingHistoryService
                .GetAllReadingHistoryWithChapter();

            var reviewComicModels = _reviewComicService
                .GetAllReviewComic();

            //Dto for returning
            ICollection<GetAllComicAction_Out_Dto> getAllComicDtos = new List<GetAllComicAction_Out_Dto>();

            foreach (var comicModel in comicModels)
            {
                //create dto for each comicModel
                var getAllComicDto = _mapper.Map<GetAllComicAction_Out_Dto>(source: comicModel);

                //get the current number of reader for each comic
                readingHistoryJoinChapterModels.ForEach(readingHistoryJoinChapterModel =>
                {
                    if (comicModel.ComicIdentifier
                        == readingHistoryJoinChapterModel.ChapterModel.ComicIdentifier)
                    {
                        getAllComicDto.NumberOfReaderHasRead++;
                    }
                });

                //get the current number of review for each comic
                reviewComicModels.ForEach(reviewComicModel =>
                {
                    if (comicModel.ComicIdentifier
                        == reviewComicModel.ComicIdentifier)
                    {
                        getAllComicDto.ReviewCount++;
                    }
                });

                //get the lastest review for each comic
                foreach (var reviewComicModel in reviewComicModels
                    .OrderByDescending(reviewComicModel => reviewComicModel.ReviewTime))
                {
                    if (comicModel.ComicIdentifier
                        == reviewComicModel.ComicIdentifier)
                    {
                        getAllComicDto.LastestComicReviewDate = reviewComicModel.ReviewTime;

                        break;
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
