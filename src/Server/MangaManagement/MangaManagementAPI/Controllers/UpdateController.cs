using AutoMapper;
using BusinessLogicLayer.Services;
using DTO.Incoming;
using Helper;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace MangaManagementAPI.Controllers;

[Consumes(contentType: MediaTypeNames.Application.Json)]
[Produces(contentType: MediaTypeNames.Application.Json)]
[Route(template: "api/[controller]")]
[ApiController]
public class UpdateController : ControllerBase
{
	private readonly IMapper _mapper;
	private readonly EntityManagementService _entityManagementService;

	public UpdateController(
		IMapper mapper,
		EntityManagementService entityManagementService)
	{
		_mapper = mapper;
		_entityManagementService = entityManagementService;
	}

	[HttpPut(template: "comic")]
	public async Task<IActionResult> UpdateComicToDatabaseAsync([FromBody] UpdateCrawlDataToDatabaseAction_In_Dto dto)
	{
		//get comic model from dto
		var comicModel = _mapper.Map<ComicModel>(source: dto.ComicDto);

		//get list of category model from dto
		var categoryModels = _mapper.Map<IList<CategoryModel>>(source: dto.ComicDto.ComicCategoryDtos);

		//get list of chapter model from dto
		var chapterModels = _mapper.Map<IList<ChapterModel>>(source: dto.ComicDto.ComicChapterDtos);

		chapterModels.ForEach(action: chapterModel
			=> chapterModel.ComicIdentifier = comicModel.ComicIdentifier);

		chapterModels.ForEach(action: chapterModel
			=> chapterModel.ChapterImageModels.ForEach(action: chapterImageModel
				=> chapterImageModel.ChapterIdentifier = chapterModel.ChapterIdentifier));

		await _entityManagementService.UploadCrawlDataToDatabaseAsync(
			comicModel: comicModel,
			categoryModels: categoryModels,
			chapterModels: chapterModels);

		await _entityManagementService.UpdateCrawlComicCategoryDataToDatabaseAsync(
			comicName: comicModel.ComicName,
			categoryNames: categoryModels.Select(selector: categoryModel => categoryModel.CategoryName));

		return Ok();
	}
}
