﻿using AutoMapper;
using DataAccessLayer.UnitOfWorks.Contracts;
using Entity;
using Helper.DefinedEnums;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
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

    public Task<int> Count(DefinedEntity entity)
    {
        switch (entity)
        {
            case DefinedEntity.Chapter: return _unitOfWork.ChapterRepository.Count();
            case DefinedEntity.ChapterImage: return _unitOfWork.ChapterImageRepository.Count();
            case DefinedEntity.Category: return _unitOfWork.CategoryRepository.Count();
            case DefinedEntity.Comic: return _unitOfWork.ComicRepository.Count();
            case DefinedEntity.ComicSaving: return _unitOfWork.ComicSavingRepository.Count();
        }
        return Task.FromResult(0);
    }

    /// <summary>
    /// Get all comic without any reference from database
    /// </summary>
    /// <returns>Task<IEnumerable<ComicModel></ComicModel>></returns>
    public async Task<IEnumerable<ComicModel>> GetAllComicNoRelationAsync()
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Table", args: DateTime.Now);

        var comicEntities = await _unitOfWork
            .ComicRepository
            .GetAllComicNoRelationAsync();

        _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Comic Table", args: DateTime.Now);

        return _mapper.Map<IEnumerable<ComicModel>>(source: comicEntities);
    }

    /// <summary>
    /// Get all category without any reference from database
    /// </summary>
    /// <returns>Task<IEnumerable<ComicModel></ComicModel>></returns>
    public async Task<IEnumerable<CategoryModel>> GetAllCategoryNoRelationAsync()
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Table", args: DateTime.Now);

        var comicEntities = await _unitOfWork
            .CategoryRepository
            .GetAllCategoryNoRelationAsync();

        _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Comic Table", args: DateTime.Now);

        return _mapper.Map<IEnumerable<CategoryModel>>(source: comicEntities);
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
            .GetChapterWithComicByChapterIdentifierFromDatabaseAsync(chapterIdentifier: chapterIdentifier);

        chapterEntity.ReviewChapterEntities = await _unitOfWork
            .ReviewChapterRepository
            .GetChapterReviewsOfAChapterAsync(chapterIdentifier: chapterIdentifier);

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
            .GetChapterImagesByChapterIdentifierFromDatabaseAsync(chapterIdentifier: chapterIdentifer);

        _logger.LogWarning(message: "[{DateTime.Now}]: End Querying On ChapterImage Table", args: DateTime.Now);

        return _mapper.Map<IEnumerable<ChapterImageModel>>(source: chapterImageEntities);
    }

    /// <summary>
    /// Get all comic without any reference from database
    /// </summary>
    /// <returns>Task<IEnumerable<ComicModel></ComicModel>></returns>
    public async Task<IEnumerable<ComicModel>> GetAllComicWith_ComicIdentifier_ComicPublishedDate_ComicName_ComicAvatarAsync()
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Table", args: DateTime.Now);

        var comicJoinReviewComicEntities = await _unitOfWork
            .ComicRepository
            .GetAllComicWith_ComicIdentifier_ComicPublishedDate_ComicName_ComicAvatarAsync();

        _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Comic Table", args: DateTime.Now);

        return _mapper.Map<IEnumerable<ComicModel>>(source: comicJoinReviewComicEntities);

    }

    /// <summary>
    /// Get a comic with publisher reference by comicIdentifier from database
    /// </summary>
    /// <param name="comicIdentifer"></param>
    /// <returns>Task<ComicModel></returns>
    public async Task<ComicModel> GetComicWith_ComicIdentifier_ComicName_ComicDescription_ComicAvatar_ComicPublishedDate_Username_ByComicIdentifierAsync(Guid comicIdentifer)
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Table", args: DateTime.Now);

        var comicEntity = await _unitOfWork
            .ComicRepository
            .GetComicWith_ComicIdentifier_ComicName_ComicDescription_ComicAvatar_ComicPublishedDate_Username_ByComicIdentifierAsync(comicIdentifier: comicIdentifer);

        comicEntity.ChapterEntities = await _unitOfWork
            .ChapterRepository
            .GetChapterWith_ChapterIdentifier_ChapterNumber_ChapterUnlockPrice_ChapterAddedDateAsync(comicIdentifier: comicIdentifer);

        _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Comic Table", args: DateTime.Now);

        return _mapper.Map<ComicModel>(source: comicEntity);

    }

    /// <summary>
    /// Get publisher with user reference by publisher identifier from database
    /// </summary>
    /// <param name="publisherIdentifier"></param>
    /// <returns>Task<Publisher></returns>
    public async Task<PublisherModel> GetPublisherWith_UsernameByPublisherIdentifierAsync(Guid publisherIdentifier)
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Publisher Table", args: DateTime.Now);

        var publisherEntity = await _unitOfWork
            .PublisherRepository
            .GetPublisherWith_UsernameByPublisherIdentifierAsync(publisherIdentifier: publisherIdentifier);

        _logger.LogWarning(message: "[{DateTime.Now}]: End Querying On Publisher Table", args: DateTime.Now);

        return _mapper.Map<PublisherModel>(source: publisherEntity);
    }

    /// <summary>
    /// Get all reading history with reference chapter from database
    /// </summary>
    /// <returns>Task<IEnumerable<ReadingHistoryModel>>></returns>
    public async Task<IEnumerable<ReadingHistoryModel>> GetAllReadingHistoriesWith_ChapterIdentifierAsync()
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Reading History Table", args: DateTime.Now);

        var readingHistoryWithChapterEntities = await _unitOfWork
            .ReadingHistoryRepository
            .GetAllReadingHistoriesWith_ChapterIdentifierAsync();

        _logger.LogWarning(message: "[{DateTime.Now}]: End Querying On Reading History Table", args: DateTime.Now);

        return _mapper.Map<IEnumerable<ReadingHistoryModel>>(source: readingHistoryWithChapterEntities);
    }

    /// <summary>
    /// Get all reading history chapter without reference by comic identifier from the database
    /// </summary>
    /// <param name="comicIdentifier"></param>
    /// <returns>Task<IEnumerable<ReadingHistoryModel>></returns>
    public async Task<int> GetReadingHistoryCountWith_ChapterIdentifierByComicIdentiferAsync(Guid comicIdentifier)
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Reading History Table", args: DateTime.Now);

        var readingHistoryCount = await _unitOfWork
            .ReadingHistoryRepository
            .GetReadingHistoryCountWith_ChapterIdentifierByComicIdentiferAsync(comicIdentifier: comicIdentifier);

        _logger.LogWarning(message: "[{DateTime.Now}]: End Querying On Reading History Table", args: DateTime.Now);

        return readingHistoryCount;
    }

    /// <summary>
    /// Get all review comic without any reference from the database
    /// </summary>
    /// <returns>Task<IEnumerable<ReviewComicModel>></returns>
    public async Task<IEnumerable<ReviewComicModel>> GetAllReviewComicsWith_ComicIdentifier_ReviewTimeAsync()
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Review Comic Table", args: DateTime.Now);

        var reviewComic = await _unitOfWork
            .ReviewComicRepository
            .GetAllReviewComicsWith_ComicIdentifier_ReviewTimeAsync();

        _logger.LogWarning(message: "[{DateTime.Now}]: End Querying On Review Comic Table", args: DateTime.Now);

        return _mapper.Map<IEnumerable<ReviewComicModel>>(source: reviewComic);
    }

    /// <summary>
    /// Get all review comic without any reference by comic identifier from the database
    /// </summary>
    /// <param name="comicIdentifier"></param>
    /// <returns>Task<IEnumerable<ReviewComicModel></ReviewComicModel>></returns>
    public async Task<IEnumerable<ReviewComicModel>> GetAllReviewComicWith_ComicRatingStar_ComicComment_ReviewTime_Username_UserAvatarByComicIdentifierAsync(Guid comicIdentifier)
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Review Comic Table", args: DateTime.Now);

        var reviewComic = await _unitOfWork
            .ReviewComicRepository
            .GetAllReviewComicsWith_ComicRatingStar_ComicComment_ReviewTime_Username_UserAvatarByComicIdentifierAsync(comicIdentifier: comicIdentifier);

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
    /// <param name="crawlComicModel"></param>
    /// <param name="crawlCategoryModels"></param>
    /// <param name="crawlChapterModels"></param>
    /// <returns></returns>
    public async Task UploadCrawlDataToDatabaseAsync(
        ComicModel crawlComicModel,
        IList<CategoryModel> crawlCategoryModels,
        IList<ChapterModel> crawlChapterModels)
    {
        //add new category to db
        await _unitOfWork
            .CategoryRepository
            .UpdateCrawlDataAsync(crawlCategoryEntities: _mapper.Map<IList<CategoryEntity>>(source: crawlCategoryModels));

        await _unitOfWork.SaveAsync();

        //upload new comic to database and return new comic identifier or return old comic identifier if exist
        var comicIdentifier = await _unitOfWork
           .ComicRepository
           .UpdateCrawlDataAsync(crawlComicEntity: _mapper.Map<ComicEntity>(source: crawlComicModel));

        //upload all chapter to database
        await _unitOfWork
            .ChapterRepository
            .UpdateCrawlDataAsync(
                crawlChapterEntities: _mapper.Map<IList<ChapterEntity>>(source: crawlChapterModels),
                comicIdentifier: comicIdentifier);

        //delete all comic category related to this comic
        _unitOfWork
            .ComicCategoryRepository
            .DeleteComicCategoriesByComicIdentifier(comicIdentifier: comicIdentifier);

        //take out category name
        var crawlCategoryNames = crawlCategoryModels
            .Select(selector: crawlCategoryModel
                => crawlCategoryModel.CategoryName);

        //get all category identifiers base on category name
        var categoryIdentifiers = await _unitOfWork
            .CategoryRepository
            .GetCategoryIdentifiersByCrawlCategoryNameAsync(crawlCategoryNames: crawlCategoryNames);

        //add all category related of comic to db
        await _unitOfWork
            .ComicCategoryRepository
            .UpdateCrawlDataAsync(
                comicIdentifier: comicIdentifier,
                categoryidentifiers: categoryIdentifiers);

        await _unitOfWork.SaveAsync();
    }

    public async Task<IEnumerable<ChapterModel>> GetAllChaptersWith_ChapterNumberAsync()
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Chapter Table", args: DateTime.Now);

        var comicCategory = await _unitOfWork
            .ChapterRepository
            .GetAllChapterWith_ChapterNumber_ComicIdentitiferAsync();

        _logger.LogWarning(message: "[{DateTime.Now}]: End Querying On Chapter Table", args: DateTime.Now);

        return _mapper.Map<IEnumerable<ChapterModel>>(source: comicCategory);
    }

    //void ForAdminOperation()
    //_unitofwork.ChapterImageRepo
}
