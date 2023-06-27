using AutoMapper;
using BusinessLogicLayer.Services;
using DTO;
using DTO.Outgoing;
using Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace DataAccessLayer.Controllers;

[Consumes(contentType: MediaTypeNames.Application.Json)]
[Produces(contentType: MediaTypeNames.Application.Json)]
[Route(template: "api/[controller]")]
[ApiController]
public class ComicController : ControllerBase
{
    private readonly EntityManagementService _entityManagementService;
    private readonly ILogger<ComicController> _logger;
    private readonly IMapper _mapper;

    public ComicController(
        EntityManagementService entityManagementService,
        ILogger<ComicController> logger,
        IMapper mapper)
    {
        _entityManagementService = entityManagementService;
        _logger = logger;
        _mapper = mapper;
    }



    /// <summary>
    /// Return some general information about all comic
    /// </summary>
    /// <returns>[200 - 500]</returns>
    [HttpGet]
    public async Task<IActionResult> GetAllComicAsync()
    {
        _logger.LogCritical(message: "Endpoint api/comic !!");

        try
        {
            var comicModels = await _entityManagementService
                .GetAllComicsWith_ComicIdentifier_ComicPublishedDate_ComicName_ComicAvatarAsync();

            var readingHistoryCounts = await _entityManagementService
                .GetReadingHistoryCountOfAllComicsAsync();

            var reviewComicCounts = await _entityManagementService
                .GetReviewComicCountOfAllComicsAsync();

            var latestChapters = await _entityManagementService
                .GetTheLastestChapterNumberOfAllComicsAsync();

            var lastestComicReviews = await _entityManagementService
                .GetLastestComicReviewDateOfAllComicsAsync();

            //list of dto for returning
            var dtos = _mapper.Map<IEnumerable<GetAllComicAction_Out_Dto>>(source: comicModels);

            dtos.ForEach(action: dto =>
            {
                //set the review comic count for dto
                foreach (var reviewComicCount in reviewComicCounts)
                {
                    if (reviewComicCount.Key.Equals(g: dto.ComicIdentifier))
                    {
                        dto.ReviewCounts = reviewComicCount.Value;

                        break;
                    }
                }

                //set the comic lastest chapter for dto
                foreach (var latestChapter in latestChapters)
                {
                    if (latestChapter.Key.Equals(g: dto.ComicIdentifier))
                    {
                        dto.ComicLatestChapter = latestChapter.Value;

                        break;
                    }
                }

                //set the reader count for dto
                foreach (var readingHistory in readingHistoryCounts)
                {
                    if (readingHistory.Key.Equals(g: dto.ComicIdentifier))
                    {
                        dto.ReadersCounts = readingHistory.Value;

                        break;
                    }
                }

                //set latest comic review date for dto
                foreach (var lastestComicReview in lastestComicReviews)
                {
                    if (lastestComicReview.Key.Equals(g: dto.ComicIdentifier))
                    {
                        dto.LastestComicReviewDate = lastestComicReview.Value;

                        break;
                    }
                }
            });

            return Ok(value: dtos);
        }
        catch (NpgsqlException N_e)
        {
            _logger.LogError(message: $"[{DateTime.Now}]: Error: {N_e.Message}");

            return StatusCode(statusCode: StatusCodes.Status500InternalServerError);
        }
        catch (Exception e)
        {
            _logger.LogError(message: $"[{DateTime.Now}]: Error: {e.Message}");

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
        _logger.LogCritical(message: "Endpoint api/comic/{comicIdentifier} !!", comicIdentifier);

        try
        {
            var comicModel = await _entityManagementService
                .GetComicWith_ComicIdentifier_ComicName_ComicDescription_ComicAvatar_ComicPublishedDate_PublisherIdentifier_ByComicIdentifierAsync(comicIdentifer: comicIdentifier);

            var publisherModel = await _entityManagementService
                .GetPublisherWith_UsernameByPublisherIdentifierAsync(publisherIdentifier: comicModel.PublisherIdentifier);

            var reviewComicModels = await _entityManagementService
                .GetAllReviewComicWith_ComicRatingStar_ComicComment_ReviewTime_Username_UserAvatarByComicIdentifierAsync(comicIdentifier: comicIdentifier);

            var readingHistoryCount = await _entityManagementService
                .GetReadingHistoryCountByComicIdentiferAsync(comicIdentifier: comicIdentifier);

            var comicCategoryModels = await _entityManagementService
                .GetAllComicCategoryByComicIdentifierAsync(comicIdentifier: comicIdentifier);

            //Dto for return result
            var comicDetailDto = _mapper.Map<GetComicDetailAction_Out_Dto>(source: comicModel);

            //set publisher name for dto
            comicDetailDto.PublisherName = publisherModel.UserModel.Username;

            //set number fo reader for dto
            comicDetailDto.ReaderCounts = readingHistoryCount;

            //set review comic for dto
            comicDetailDto.ReviewComics = _mapper.Map<IEnumerable<GetComicDetailAction_Out_Dto.ReviewComicDto>>(source: reviewComicModels);

            //set all category for dto
            comicCategoryModels.ForEach(action: comicCategoryModel
                => comicDetailDto.CategoryNames.Add(item: comicCategoryModel.CategoryModel.CategoryName));

            return Ok(value: comicDetailDto);
        }
        catch (NpgsqlException N_e)
        {
            _logger.LogError(message: $"[{DateTime.Now}]: Error: {N_e.Message}");

            return StatusCode(statusCode: StatusCodes.Status500InternalServerError);
        }
    }
}
