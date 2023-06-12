using AutoMapper;
using DataAccessLayer.UnitOfWorks.Contracts;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.EntityManagementServices;

public class ReadingHistoryServiceManagement
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly ILogger<ReadingHistoryServiceManagement> _logger;

    public ReadingHistoryServiceManagement(
        IUnitOfWork unitOfWork,
        IMapper mapper,
        ILogger<ReadingHistoryServiceManagement> logger)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _logger = logger;
    }

    /// <summary>
    /// Get all reading history with reference chapter from database
    /// </summary>
    /// <returns>IEnumerable<ReadingHistoryModel></returns>
    public async Task<IEnumerable<ReadingHistoryModel>> GetAllReadingHistoryWithChapterAsync()
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Reading History Table", args: DateTime.Now);

        var readingHistoryWithChapterEntities = await _unitOfWork
            .ReadingHistoryRepository
            .GetAllReadingHistoryWithChapterFromDatabaseAsync();

        _logger.LogWarning(message: "[{DateTime.Now}]: End Querying On Reading History Table", args: DateTime.Now);

        return _mapper.Map<IEnumerable<ReadingHistoryModel>>(source: readingHistoryWithChapterEntities);
    }

    /// <summary>
    /// Get all reading history chapter by ComicIdentifier without reference from the database
    /// </summary>
    /// <param name="comicIdentifier"></param>
    /// <returns> IEnumerable<ReadingHistoryModel></returns>
    public async Task<IEnumerable<ReadingHistoryModel>> GetAllReadingHistoryByComicIdentifierAsync(Guid comicIdentifier)
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Reading History Table", args: DateTime.Now);

        var readingHistoryWithChapterEntities = await _unitOfWork
            .ReadingHistoryRepository
            .GetAllReadingHistoryByComicIdentiferFromDatabaseAsync(comicIdentifier: comicIdentifier);

        _logger.LogWarning(message: "[{DateTime.Now}]: End Querying On Reading History Table", args: DateTime.Now);

        return _mapper.Map<IEnumerable<ReadingHistoryModel>>(source: readingHistoryWithChapterEntities);
    }
}
