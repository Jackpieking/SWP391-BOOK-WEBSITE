using AutoMapper;
using BusinessLogicLayer.Services.EntityManagementServices;
using DTO;
using DTO.Outgoing;
using Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace DataAccessLayer.Controllers;

[Consumes(contentType: MediaTypeNames.Application.Json)]
[Produces(contentType: MediaTypeNames.Application.Json)]
[Route(template: "api/[controller]")]
[ApiController]
public class ComicController : ControllerBase
{
    private readonly ComicServiceManagement _comicService;
    private readonly ReadingHistoryServiceManagement _readingHistoryService;
    private readonly ReviewComicServiceManagement _reviewComicService;
    private readonly PublisherServiceManagement _publisherService;
    private readonly ComicCategoryManagementService _comicCategoryManagementService;
    private readonly ILogger<ComicController> _logger;
    private readonly IMapper _mapper;

    public ComicController(
        ComicServiceManagement comicService,
        ILogger<ComicController> logger,
        IMapper mapper,
        ReadingHistoryServiceManagement readingHistoryService,
        ReviewComicServiceManagement reviewComicService,
        PublisherServiceManagement publisherService,
        ComicCategoryManagementService comicCategoryManagementService)
    {
        _comicService = comicService;
        _logger = logger;
        _mapper = mapper;
        _readingHistoryService = readingHistoryService;
        _reviewComicService = reviewComicService;
        _publisherService = publisherService;
        _comicCategoryManagementService = comicCategoryManagementService;
    }

    /// <summary>
    /// Return some general information about all comic
    /// </summary>
    /// <returns>[200 - 500]</returns>
    [HttpGet]
    public async Task<IActionResult> GetAllComicGeneralInformationAsync()
    {
        try
        {
            var comicModels = await _comicService
                .GetAllComicAsync();

            var readingHistoryJoinChapterModels = await _readingHistoryService
                .GetAllReadingHistoryWithChapterAsync();

            var reviewComicModels = await _reviewComicService
                .GetAllReviewComicAsync();

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
                        getAllComicDto.ReadersCounts++;
                    }
                });

                //get the current number of review for each comic
                reviewComicModels.ForEach(reviewComicModel =>
                {
                    if (comicModel.ComicIdentifier
                        == reviewComicModel.ComicIdentifier)
                    {
                        getAllComicDto.ReviewCounts++;
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

    /// <summary>
    /// Return a comic detail by comicIdentifier
    /// </summary>
    /// <param name="comicIdentifier"></param>
    /// <returns>[200 - 404]</returns>
    [HttpGet(template: "{comicIdentifier:guid}")]
    public async Task<IActionResult> GetComicDetailAsync([FromRoute] Guid comicIdentifier)
    {
        try
        {
            var comicModel = await _comicService
                .GetAComicWithListOfChapterByComicIdentifierAsync(comicIdentifer: comicIdentifier);

            var publisherModel = await _publisherService
                .GetPublisherWithUserByPublisherIdentifierAsync(publisherIdentifier: comicModel.PublisherModel.PublisherIdentifier);

            var reviewComicModels = await _reviewComicService
                .GetAllReviewComicByComicIdentifierAsync(comicIdentifier: comicIdentifier);

            var readingHistoryModels = await _readingHistoryService
                .GetAllReadingHistoryByComicIdentifierAsync(comicIdentifier: comicIdentifier);

            var comicCategoryModels = await _comicCategoryManagementService
                .GetAllComicCategoryByComicIdentifierAsync(comicIdentifier);

            if (Equals(objA: comicModel, objB: null))
            {
                return NotFound();
            }

            //Dto for return result
            var getComicDetailDto = _mapper.Map<GetComicDetailAction_Out_Dto>(source: comicModel);

            getComicDetailDto.PublisherName = publisherModel.UserModel.Username;
            getComicDetailDto.ReaderCounts = readingHistoryModels.Count();

            reviewComicModels.ForEach(action: reviewComicModel =>
            {
                getComicDetailDto.ComicReviews
                    .Add(item: _mapper
                        .Map<GetComicDetailAction_Out_Dto.ReviewComicDto>(source: reviewComicModel));
            });

            comicCategoryModels.ForEach(action: comicCategoryModel
                => getComicDetailDto.CategoryNames
                    .Add(item: comicCategoryModel.CategoryModel.CategoryName));

            return Ok(value: getComicDetailDto);
        }
        catch (NpgsqlException N_e)
        {
            _logger.LogError(message: $"[{DateTime.Now}]: Error: {N_e.Message}");

            return StatusCode(statusCode: StatusCodes.Status500InternalServerError);
        }
    }
}
