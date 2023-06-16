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
	public async Task<IActionResult> GetAllComicGeneralInformationAsync()
	{
		try
		{
			var comicModels = await _entityManagementService
				.GetAllComicAsync();

			var readingHistoryModels = await _entityManagementService
				.GetAllReadingHistoriesWithChapterAsync();

			var reviewComicModels = await _entityManagementService
				.GetAllReviewComicAsync();

			//list of dto for returning
			ICollection<GetAllComicAction_Out_Dto> getAllComicDtolist = new List<GetAllComicAction_Out_Dto>();

			foreach (var comicModel in comicModels)
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
				foreach (var reviewComicModel in reviewComicModels
					.OrderByDescending(keySelector: reviewComicModel
						=> reviewComicModel.ReviewTime))
				{
					if (comicModel.ComicIdentifier
						== reviewComicModel.ComicIdentifier)
					{
						getAllComicDto.LastestComicReviewDate = reviewComicModel.ReviewTime;

						break;
					}
				}

				getAllComicDtolist.Add(item: getAllComicDto);
			}

			return Ok(value: getAllComicDtolist);
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
			var comicModel = await _entityManagementService
				.GetAComicWithComicChapterListByComicIdentifierAsync(comicIdentifer: comicIdentifier);

			var publisherModel = await _entityManagementService
				.GetAPublisherWithUserByPublisherIdentifierAsync(publisherIdentifier: comicModel.PublisherModel.PublisherIdentifier);

			var reviewComicModels = await _entityManagementService
				.GetAllReviewComicByComicIdentifierAsync(comicIdentifier: comicIdentifier);

			var readingHistoryModels = await _entityManagementService
				.GetAllReadingHistoriesByComicIdentifierAsync(comicIdentifier: comicIdentifier);

			var comicCategoryModels = await _entityManagementService
				.GetAllComicCategoryByComicIdentifierAsync(comicIdentifier: comicIdentifier);

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
