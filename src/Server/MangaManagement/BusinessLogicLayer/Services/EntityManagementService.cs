using AutoMapper;
using DataAccessLayer.UnitOfWorks.Contracts;
using Entity;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services;

public class EntityManagementService
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;
	private readonly ILogger<EntityManagementService> _logger;

	public EntityManagementService(
		IUnitOfWork unitOfWork,
		IMapper mapper,
		ILogger<EntityManagementService> logger)
	{
		_unitOfWork = unitOfWork;
		_mapper = mapper;
		_logger = logger;
	}

	/// <summary>
	/// Get a chapter with comic and chapter reviews reference by chapter identifier from database
	/// </summary>
	/// <param name="chapterIdentifier"></param>
	/// <returns>Task<ChapterModel></returns>
	public async Task<ChapterModel> GetAChapterWithComicAndChapterReviewListByChapterIdentifierAsync(Guid chapterIdentifier)
	{
		_logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Chapter Table", args: DateTime.Now);

		var chapterEntity = await _unitOfWork
			.ChapterRepository
			.GetAChapterWithComicByChapterIdentifierFromDatabaseAsync(chapterIdentifier: chapterIdentifier);

		chapterEntity.ReviewChapterEntities = await _unitOfWork
			.ReviewChapterRepository
			.GetAllChapterReviewsOfAChapterAsync(chapterIdentifier: chapterIdentifier);

		_logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Chapter Table", args: DateTime.Now);

		return _mapper.Map<ChapterModel>(source: chapterEntity);
	}

	/// <summary>
	/// Get all chapter images of a chapter without any reference from database
	/// </summary>
	/// <param name="chapterIdentifier"></param>
	/// <returns>Task<IEnumerable<ChapterImageModel>></returns>
	public async Task<IEnumerable<ChapterImageModel>> GetAllChapterImagesOfAChapterByChapterIdentifierAsync(Guid chapterIdentifer)
	{
		_logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On ChapterImage Table", args: DateTime.Now);

		var chapterImageEntities = await _unitOfWork
			.ChapterImageRepository
			.GetAllChapterImagesOfAChapterFromDatabaseAsync(chapterIdentifier: chapterIdentifer);

		_logger.LogWarning(message: "[{DateTime.Now}]: End Querying On ChapterImage Table", args: DateTime.Now);

		return _mapper.Map<IEnumerable<ChapterImageModel>>(source: chapterImageEntities);
	}

	/// <summary>
	/// Get all comic without any reference from database
	/// </summary>
	/// <returns>Task<IEnumerable<ComicModel></ComicModel>></returns>
	public async Task<IEnumerable<ComicModel>> GetAllComicAsync()
	{
		_logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Table", args: DateTime.Now);

		var comicJoinReviewComicEntities = await _unitOfWork
			.ComicRepository
			.GetAllComicsFromDatabaseAsync();

		_logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Comic Table", args: DateTime.Now);

		return _mapper.Map<IEnumerable<ComicModel>>(source: comicJoinReviewComicEntities);

	}

	/// <summary>
	/// Get a comic with publisher reference by comicIdentifier from database
	/// </summary>
	/// <param name="comicIdentifer"></param>
	/// <returns>Task<ComicModel></returns>
	public async Task<ComicModel> GetAComicWithComicChapterListByComicIdentifierAsync(Guid comicIdentifer)
	{
		_logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Table", args: DateTime.Now);

		var comicEntity = await _unitOfWork
			.ComicRepository
			.GetComicWithChapterListByComicIdentifierDatabaseAsync(comicIdentifier: comicIdentifer);

		comicEntity.ChapterEntities = await _unitOfWork
			.ChapterRepository
			.GetAllChaptersOfAComicFromDatabaseAsync(comicIdentifier: comicIdentifer);

		_logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Comic Table", args: DateTime.Now);

		return _mapper.Map<ComicModel>(source: comicEntity);

	}

	/// <summary>
	/// Get publisher with user reference by publisher identifier from database
	/// </summary>
	/// <param name="publisherIdentifier"></param>
	/// <returns>Task<Publisher></returns>
	public async Task<PublisherModel> GetAPublisherWithUserByPublisherIdentifierAsync(Guid publisherIdentifier)
	{
		_logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Publisher Table", args: DateTime.Now);

		var publisherEntity = await _unitOfWork
			.PublisherRepository
			.GetPublisherWithUserByPublisherIdentifierFromDatabaseAsync(publisherIdentifier: publisherIdentifier);

		_logger.LogWarning(message: "[{DateTime.Now}]: End Querying On Publisher Table", args: DateTime.Now);

		return _mapper.Map<PublisherModel>(source: publisherEntity);
	}

	/// <summary>
	/// Get all reading history with reference chapter from database
	/// </summary>
	/// <returns>Task<IEnumerable<ReadingHistoryModel>>></returns>
	public async Task<IEnumerable<ReadingHistoryModel>> GetAllReadingHistoriesWithChapterAsync()
	{
		_logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Reading History Table", args: DateTime.Now);

		var readingHistoryWithChapterEntities = await _unitOfWork
			.ReadingHistoryRepository
			.GetAllReadingHistoriesWithChapterFromDatabaseAsync();

		_logger.LogWarning(message: "[{DateTime.Now}]: End Querying On Reading History Table", args: DateTime.Now);

		return _mapper.Map<IEnumerable<ReadingHistoryModel>>(source: readingHistoryWithChapterEntities);
	}

	/// <summary>
	/// Get all reading history chapter without reference by comic identifier from the database
	/// </summary>
	/// <param name="comicIdentifier"></param>
	/// <returns>Task<IEnumerable<ReadingHistoryModel>></returns>
	public async Task<IEnumerable<ReadingHistoryModel>> GetAllReadingHistoriesByComicIdentifierAsync(Guid comicIdentifier)
	{
		_logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Reading History Table", args: DateTime.Now);

		var readingHistoryWithChapterEntities = await _unitOfWork
			.ReadingHistoryRepository
			.GetAllReadingHistoriesByComicIdentiferFromDatabaseAsync(comicIdentifier: comicIdentifier);

		_logger.LogWarning(message: "[{DateTime.Now}]: End Querying On Reading History Table", args: DateTime.Now);

		return _mapper.Map<IEnumerable<ReadingHistoryModel>>(source: readingHistoryWithChapterEntities);
	}

	/// <summary>
	/// Get all review comic without any reference from the database
	/// </summary>
	/// <returns>Task<IEnumerable<ReviewComicModel>></returns>
	public async Task<IEnumerable<ReviewComicModel>> GetAllReviewComicAsync()
	{
		_logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Review Comic Table", args: DateTime.Now);

		var reviewComic = await _unitOfWork
			.ReviewComicRepository
			.GetAllReviewComicsFromDatabaseAsync();

		_logger.LogWarning(message: "[{DateTime.Now}]: End Querying On Review Comic Table", args: DateTime.Now);

		return _mapper.Map<IEnumerable<ReviewComicModel>>(source: reviewComic);
	}

	/// <summary>
	/// Get all review comic without any reference by comic identifier from the database
	/// </summary>
	/// <param name="comicIdentifier"></param>
	/// <returns>Task<IEnumerable<ReviewComicModel></ReviewComicModel>></returns>
	public async Task<IEnumerable<ReviewComicModel>> GetAllReviewComicByComicIdentifierAsync(Guid comicIdentifier)
	{
		_logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Review Comic Table", args: DateTime.Now);

		var reviewComic = await _unitOfWork
			.ReviewComicRepository
			.GetAllReviewComicsByComicIdentifierFromDatabaseAsync(comicIdentifier: comicIdentifier);

		_logger.LogWarning(message: "[{DateTime.Now}]: End Querying On Review Comic Table", args: DateTime.Now);

		return _mapper.Map<IEnumerable<ReviewComicModel>>(source: reviewComic);
	}

	/// <summary>
	/// Get all comic category with category reference by comic identifier fromm database
	/// </summary>
	/// <param name="comicIdentifier"></param>
	/// <returns>Task<IEnumerable<ComicCategoryModel></ComicCategoryModel>></returns>
	public async Task<IEnumerable<ComicCategoryModel>> GetAllComicCategoryByComicIdentifierAsync(Guid comicIdentifier)
	{
		_logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Category Table", args: DateTime.Now);

		var comicCategory = await _unitOfWork
			.ComicCategoryRepository
			.GetComicCategoryNameByComicIdentifierFromDatabaseAsync(comicIdentifier: comicIdentifier);

		_logger.LogWarning(message: "[{DateTime.Now}]: End Querying On Comic Category Table", args: DateTime.Now);

		return _mapper.Map<IEnumerable<ComicCategoryModel>>(source: comicCategory);
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="comicModel"></param>
	/// <param name="categoryModels"></param>
	/// <param name="chapterModels"></param>
	/// <returns></returns>
	public async Task UploadCrawlDataToDatabaseAsync(
		ComicModel comicModel,
		IEnumerable<CategoryModel> categoryModels,
		IEnumerable<ChapterModel> chapterModels)
	{
		var comicEntity = _mapper.Map<ComicEntity>(source: comicModel);

		await _unitOfWork
		   .ComicRepository
		   .UpdateCrawlDataAsync(crawlComicEntity: comicEntity);

		await _unitOfWork
			.CategoryRepository
			.UpdateCrawlDataAsync(crawlCategoryEntities: _mapper.Map<IEnumerable<CategoryEntity>>(source: categoryModels));

		await _unitOfWork
			.ChapterRepository
			.UpdateCrawlDataAsync(
				crawlChapterEntities: _mapper.Map<IEnumerable<ChapterEntity>>(source: chapterModels),
				comicName: comicEntity.ComicName);

		await _unitOfWork.SaveAsync();
	}

	public async Task UpdateCrawlComicCategoryDataToDatabaseAsync(
		string comicName,
		IEnumerable<string> categoryNames)
	{
		var comicIdentifier = await _unitOfWork
			.ComicRepository
			.GetComicIdentifierByComicNameAsync(comicName: comicName);

		var comicCategoryEntities = await _unitOfWork
			.ComicCategoryRepository
			.GetAllComicCategoryNameByComicIdentifierFromDatabaseAsync(comicIdentifier: comicIdentifier);

		if (comicCategoryEntities.Count == default)
		{
			var categoryIdentifiers = await _unitOfWork
				.CategoryRepository
				.GetCategoryIdentifierByCategoryNameAsync(crawlCategoryName: categoryNames);

			await _unitOfWork
				.ComicCategoryRepository
				.UpdateCrawlDataAsync(
					comicIdentifier: comicIdentifier,
					categoryidentifiers: categoryIdentifiers);
		}

		await _unitOfWork.SaveAsync();
	}
}
