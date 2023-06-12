using AutoMapper;
using DataAccessLayer.UnitOfWorks.Contracts;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.EntityManagementServices;

public class ComicServiceManagement
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly ILogger<ComicServiceManagement> _logger;

    public ComicServiceManagement(
        IUnitOfWork unitOfWork,
        IMapper mapper,
        ILogger<ComicServiceManagement> logger)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _logger = logger;
    }

    /// <summary>
    /// Get all comic without any reference from database
    /// </summary>
    /// <returns>IEnumerable<ComicModel></returns>
    public async Task<IEnumerable<ComicModel>> GetAllComicAsync()
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Table", args: DateTime.Now);

        var comicJoinReviewComicEntities = await _unitOfWork
            .ComicRepository
            .GetAllComicFromDatabaseAsync();

        _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Comic Table", args: DateTime.Now);

        return _mapper.Map<IEnumerable<ComicModel>>(source: comicJoinReviewComicEntities);

    }

    /// <summary>
    /// Get a comic by comicIdentifier with Publisher reference from database
    /// </summary>
    /// <param name="comicIdentifer"></param>
    /// <returns>Task<ComicModel></returns>
    public async Task<ComicModel> GetAComicWithListOfChapterByComicIdentifierAsync(Guid comicIdentifer)
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Table", args: DateTime.Now);

        var comicEntity = await _unitOfWork
            .ComicRepository
            .GetComicWithListOfChapterByComicIdentifierDatabaseAsync(comicIdentifier: comicIdentifer);

        comicEntity.ChapterEntities = await _unitOfWork
            .ChapterRepository
            .GetAllChapterOfAComicAsync(comicIdentifier: comicIdentifer);

        _logger.LogWarning(message: "[{DateTime.Now}]: Finish Querying On Comic Table", args: DateTime.Now);

        return _mapper.Map<ComicModel>(source: comicEntity);

    }
}
