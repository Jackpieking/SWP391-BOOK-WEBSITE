using AutoMapper;
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

public class ComicManagementService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly ILogger<ComicManagementService> _logger;

    public ComicManagementService(IUnitOfWork unitOfWork, IMapper mapper, ILogger<ComicManagementService> logger)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<ChapterModel> GetChapterByIdAsync(Guid id)
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Table", args: DateTime.Now);

        var chapter = await _unitOfWork
            .ChapterRepository
            .GetChapterByIdAsync(id);

        _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Comic Table", args: DateTime.Now);

        return _mapper.Map<ChapterModel>(source: chapter);
    }

    public IEnumerable<CategoryModel> GetCategoriesByComicId(Guid comicId)
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Table", args: DateTime.Now);

        var categories = from category in _unitOfWork.CategoryRepository.GetAllCategoryNoRelationAsync().Result
                         join comicCategory in _unitOfWork.ComicCategoryRepository.GetAllComicCategoryNoRelationAsync().Result
                         on category.CategoryIdentifier equals comicCategory.CategoryIdentifier
                         where comicCategory.CategoryIdentifier == comicId
                         select category;

        _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Comic Table", args: DateTime.Now);

        return _mapper.Map<IEnumerable<CategoryModel>>(categories);
    }

    public async Task<ComicModel> GetComicByIdAsync(Guid comicId)
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Table", args: DateTime.Now);

        var comic = await _unitOfWork
            .ComicRepository
            .GetComicByIdAsync(comicId);

        _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Comic Table", args: DateTime.Now);

        return _mapper.Map<ComicModel>(source: comic);
    }

    public async Task<ComicModel> GetComicByIdNoRelationAsync(Guid comicId)
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Table", args: DateTime.Now);

        var comic = await _unitOfWork
            .ComicRepository
            .GetComicByIdNoRelationAsync(comicId);

        _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Comic Table", args: DateTime.Now);

        return _mapper.Map<ComicModel>(source: comic);
    }

    /// <summary>
    ///
    /// </summary>
    /// <returns>Task</returns>
    public async Task<CategoryModel> GetCategoryByIdAsync(Guid id)
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Table", args: DateTime.Now);

        var category = await _unitOfWork
            .CategoryRepository
            .GetCategoryByIdAsync(id);

        _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Comic Table", args: DateTime.Now);

        return _mapper.Map<CategoryModel>(source: category);
    }

    /// <summary>
    ///
    /// </summary>
    /// <returns>Task</returns>
    public async Task UpdateCategory(CategoryModel category)
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Table", args: DateTime.Now);

        await _unitOfWork.CategoryRepository.UpdateCategory(_mapper.Map<CategoryEntity>(category));
        await _unitOfWork.SaveAsync();

        _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Comic Table", args: DateTime.Now);
    }

    /// <summary>
    ///
    /// </summary>
    /// <returns>Task</returns>
    public async Task UpdateComicAsync(Guid comicId, string comicName, string comicDes, string comicPDate, string comicStatus)
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Table", args: DateTime.Now);

        await _unitOfWork.ComicRepository.UpdateComicAsync(comicId, comicName, comicDes, comicPDate, comicStatus);
        await _unitOfWork.SaveAsync();

        _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Comic Table", args: DateTime.Now);
    }

    /// <summary>
    ///
    /// </summary>
    /// <returns>Task</returns>
    public async Task<Guid> Delete(DefinedEntity entity, Guid id)
    {
        _logger.LogWarning(message: $"[{DateTime.Now}]: Start Querying On {entity} Table", args: DateTime.Now);

        switch (entity)
        {
            case DefinedEntity.Comic:
                {
                    ComicEntity comic = _unitOfWork.ComicRepository.GetComicByIdNoRelationAsync(id).Result;
                    _unitOfWork.ComicRepository.Delete(comic);
                    await _unitOfWork.SaveAsync();
                    return comic.ComicIdentifier;
                };
            case DefinedEntity.Category:
                {
                    CategoryEntity category = _unitOfWork.CategoryRepository.GetCategoryByIdAsync(id).Result;
                    _unitOfWork.CategoryRepository.Delete(category);
                    await _unitOfWork.SaveAsync();
                    return category.CategoryIdentifier;
                }
            case DefinedEntity.Chapter:
                {
                    ChapterEntity chapter = _unitOfWork.ChapterRepository.GetChapterByIdAsync(id).Result;
                    _unitOfWork.ChapterRepository.Delete(chapter);
                    await _unitOfWork.SaveAsync();
                    return chapter.ChapterIdentifier;
                };
        }

        return Guid.Empty;
    }

    /// <summary>
    /// Get all comic without any reference from database
    /// </summary>
    /// <returns>Task<IEnumerable<ComicModel>></returns>
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
    /// <returns>Task<IEnumerable<ComicModel>></returns>
    public async Task<IEnumerable<CategoryModel>> GetAllCategoryNoRelationAsync()
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Table", args: DateTime.Now);

        var comicEntities = await _unitOfWork
            .CategoryRepository
            .GetAllCategoryNoRelationAsync();

        _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Comic Table", args: DateTime.Now);

        return _mapper.Map<IEnumerable<CategoryModel>>(source: comicEntities);
    }
}