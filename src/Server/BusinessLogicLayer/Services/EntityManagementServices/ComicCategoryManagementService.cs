using AutoMapper;
using DataAccessLayer.UnitOfWorks.Contracts;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.EntityManagementServices;

public class ComicCategoryManagementService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly ILogger<ComicCategoryManagementService> _logger;

    public ComicCategoryManagementService(
        IUnitOfWork unitOfWork,
        IMapper mapper,
        ILogger<ComicCategoryManagementService> logger)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _logger = logger;
    }

    /// <summary>
    /// Get all comic category with category reference by comic identifier fromm database
    /// </summary>
    /// <param name="comicIdentifier"></param>
    /// <returns>IEnumerable<ComicCategoryModel></returns>
    public async Task<IEnumerable<ComicCategoryModel>> GetAllComicCategoryByComicIdentifierAsync(Guid comicIdentifier)
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Comic Category Table", args: DateTime.Now);

        var comicCategory = await _unitOfWork
            .ComicCategoryRepository
            .GetAllComicCategoryByComicIdentifierFromDatabaseAsync(comicIdentifier: comicIdentifier);

        _logger.LogWarning(message: "[{DateTime.Now}]: End Querying On Comic Category Table", args: DateTime.Now);

        return _mapper.Map<IEnumerable<ComicCategoryModel>>(source: comicCategory);
    }
}
