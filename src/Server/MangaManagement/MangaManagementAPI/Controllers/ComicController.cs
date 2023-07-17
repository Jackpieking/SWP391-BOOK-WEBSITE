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
        _logger.LogCritical(message: "Start Transaction Get All Comic !!");

        try
        {
            var comicModels = await _entityManagementService
                .GetAllComicWith_ComicIdentifier_ComicPublishedDate_ComicName_ComicAvatarAsync();

            var readingHistoryModels = await _entityManagementService
                .GetAllReadingHistoriesWith_ChapterIdentifierAsync();

            var reviewComicModels = await _entityManagementService
                .GetAllReviewComicsWith_ComicIdentifier_ReviewTimeAsync();

            var chapterModels = await _entityManagementService
                .GetAllChaptersWith_ChapterNumberAsync();

            //list of dto for returning
            ICollection<GetAllComicAction_Out_Dto> getAllComicDtolist = new List<GetAllComicAction_Out_Dto>();

            comicModels.ForEach(comicModel =>
            {
                //create dto for each comicModel
                var getAllComicDto = _mapper.Map<GetAllComicAction_Out_Dto>(source: comicModel);

                //get the current number of reader for each comic
                readingHistoryModels.ForEach(action: readingHistoryModel =>
                {
                    if (comicModel.ComicIdentifier
                        == readingHistoryModel.ChapterModel.ComicIdentifier)
                    {
                        getAllComicDto.ReadersCounts++;
                    }
                });

                //get the current number of review for each comic
                reviewComicModels.ForEach(action: reviewComicModel =>
                {
                    if (comicModel.ComicIdentifier
                        == reviewComicModel.ComicIdentifier)
                    {
                        getAllComicDto.ReviewCounts++;
                    }
                });

                //get the lastest review for each comic
                foreach (var reviewComicModel in reviewComicModels)
                {
                    if (comicModel.ComicIdentifier == reviewComicModel.ComicIdentifier)
                    {
                        getAllComicDto.LastestComicReviewDate = reviewComicModel.ReviewTime;

                        break;
                    }
                }

                //get the latest chapter
                foreach (var chapterModel in chapterModels)
                {
                    if (chapterModel.ComicIdentifier == comicModel.ComicIdentifier)
                    {
                        getAllComicDto.ComicLatestChapter = chapterModel.ChapterNumber;

                        break;
                    }
                }

                //add to dto container
                getAllComicDtolist.Add(item: getAllComicDto);
            });

            return Ok(value: getAllComicDtolist);
        }
        catch (NpgsqlException N_e)
        {
            _logger.LogError(message: $"[{DateTime.Now}]: Error: {N_e.Message}");

            return StatusCode(statusCode: StatusCodes.Status500InternalServerError);
        }
        finally
        {
            _logger.LogCritical(message: "End Transaction Get All Comic !!");
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
        _logger.LogCritical(message: "Start Transaction Get Comic Detail !!");

        try
        {
            var comicModel = await _entityManagementService
                .GetComicWith_ComicIdentifier_ComicName_ComicDescription_ComicAvatar_ComicPublishedDate_Username_ByComicIdentifierAsync(comicIdentifer: comicIdentifier);


            if (Equals(objA: comicModel, objB: null))
            {
                return NotFound();
            }

            var publisherModel = await _entityManagementService
                .GetPublisherWith_UsernameByPublisherIdentifierAsync(publisherIdentifier: comicModel.PublisherIdentifier);

            var reviewComicModels = await _entityManagementService
                .GetAllReviewComicWith_ComicRatingStar_ComicComment_ReviewTime_Username_UserAvatarByComicIdentifierAsync(comicIdentifier: comicIdentifier);

            var readingHistoryCount = await _entityManagementService
                .GetReadingHistoryCountWith_ChapterIdentifierByComicIdentiferAsync(comicIdentifier: comicIdentifier);

            var comicCategoryModels = await _entityManagementService
                .GetAllComicCategoryByComicIdentifierAsync(comicIdentifier: comicIdentifier);

            //Dto for return result
            var comicDetailDto = _mapper.Map<GetComicDetailAction_Out_Dto>(source: comicModel);

            comicDetailDto.PublisherName = publisherModel.UserModel.Username;

            comicDetailDto.ReaderCounts = readingHistoryCount;

            comicDetailDto.ReviewComics = _mapper.Map<List<GetComicDetailAction_Out_Dto.ReviewComicDto>>(source: reviewComicModels);

            comicCategoryModels.ForEach(action: comicCategoryModel
                => comicDetailDto.CategoryNames.Add(item: comicCategoryModel.CategoryModel.CategoryName));

            return Ok(value: comicDetailDto);
        }
        catch (NpgsqlException N_e)
        {
            _logger.LogError(message: $"[{DateTime.Now}]: Error: {N_e.Message}");

            return StatusCode(statusCode: StatusCodes.Status500InternalServerError);
        }
        finally
        {
            _logger.LogCritical(message: "End Transaction Get Comic Detail !!");
        }
    }
}
