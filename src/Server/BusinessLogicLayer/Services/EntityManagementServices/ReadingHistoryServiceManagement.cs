using AutoMapper;
using DataAccessLayer.UnitOfWorks.Contracts;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Collections.Generic;

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
    public IEnumerable<ReadingHistoryModel> GetAllReadingHistoryWithChapter()
    {
        _logger.LogCritical(message: "[{DateTime.Now}]: Start Querying On Reading History Table", args: DateTime.Now);

        var readingHistoryWithChapterEntities = _unitOfWork
            .ReadingHistoryRepository
            .GetAllReadingHistoryWithChapterFromDatabase();

        _logger.LogCritical(message: "[{DateTime.Now}]: End Querying On Reading History Table", args: DateTime.Now);

        return _mapper.Map<IEnumerable<ReadingHistoryModel>>(source: readingHistoryWithChapterEntities);
    }

    /// <summary>
    /// Get all reading history chapter by ComicIdentifier without reference from the database
    /// </summary>
    /// <param name="comicIdentifier"></param>
    /// <returns> IEnumerable<ReadingHistoryModel></returns>
    public IEnumerable<ReadingHistoryModel> GetAllReadingHistoryByComicIdentifier(Guid comicIdentifier)
    {
        _logger.LogCritical(message: "[{DateTime.Now}]: Start Querying On Reading History Table", args: DateTime.Now);

        var readingHistoryWithChapterEntities = _unitOfWork
            .ReadingHistoryRepository
            .GetAllReadingHistoryByComicIdentiferFromDatabase(comicIdentifier: comicIdentifier);

        _logger.LogCritical(message: "[{DateTime.Now}]: End Querying On Reading History Table", args: DateTime.Now);

        return _mapper.Map<IEnumerable<ReadingHistoryModel>>(source: readingHistoryWithChapterEntities);
    }
}
