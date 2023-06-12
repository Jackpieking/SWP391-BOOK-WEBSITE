using AutoMapper;
using DataAccessLayer.UnitOfWorks.Contracts;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.EntityManagementServices;

public class ChapterImageManagementService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly ILogger<ChapterImageManagementService> _logger;

    public ChapterImageManagementService(
        IUnitOfWork unitOfWork,
        IMapper mapper,
        ILogger<ChapterImageManagementService> logger)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _logger = logger;
    }


    /// <summary>
    /// Get all chapter images of a chapter without any reference from database
    /// </summary>
    /// <returns>IEnumerable<ComicModel></returns>
    public async Task<IEnumerable<ChapterImageModel>> GetAllChapterImageOfAChapterAsync(Guid chapterIdentifer)
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On ChapterImage Table", args: DateTime.Now);

        var chapterImageEntities = await _unitOfWork
            .ChapterImageRepository
            .GetAllChapterImageOfAChapterFromDatabaseAsync(chapterIdentifier: chapterIdentifer);

        _logger.LogWarning(message: "[{DateTime.Now}]: End Querying On ChapterImage Table", args: DateTime.Now);

        return _mapper.Map<IEnumerable<ChapterImageModel>>(source: chapterImageEntities);
    }
}
