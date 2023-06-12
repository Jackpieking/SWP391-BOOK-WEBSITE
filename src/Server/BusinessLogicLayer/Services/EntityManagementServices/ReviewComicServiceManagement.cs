using AutoMapper;
using DataAccessLayer.UnitOfWorks.Contracts;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.EntityManagementServices;

public class ReviewComicServiceManagement
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly ILogger<ReviewComicServiceManagement> _logger;

    public ReviewComicServiceManagement(
        IUnitOfWork unitOfWork,
        IMapper mapper,
        ILogger<ReviewComicServiceManagement> logger)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _logger = logger;
    }

    /// <summary>
    /// Get all review comic without any reference from the database
    /// </summary>
    /// <returns>IEnumerable<ReviewComicModel></returns>
    public async Task<IEnumerable<ReviewComicModel>> GetAllReviewComicAsync()
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Review Comic Table", args: DateTime.Now);

        var reviewComic = await _unitOfWork
            .ReviewComicRepository
            .GetAllReviewComicFromDatabaseAsync();

        _logger.LogWarning(message: "[{DateTime.Now}]: End Querying On Review Comic Table", args: DateTime.Now);

        return _mapper.Map<IEnumerable<ReviewComicModel>>(source: reviewComic);
    }

    /// <summary>
    /// Get all review comic by comicIdentifier without any reference from the database
    /// </summary>
    /// <param name="comicIdentifier"></param>
    /// <returns>IEnumerable<ReviewComicModel></returns>
    public async Task<IEnumerable<ReviewComicModel>> GetAllReviewComicByComicIdentifierAsync(Guid comicIdentifier)
    {
        _logger.LogWarning(message: "[{DateTime.Now}]: Start Querying On Review Comic Table", args: DateTime.Now);

        var reviewComic = await _unitOfWork
            .ReviewComicRepository
            .GetAllReviewComicByComicIdentifierFromDatabaseAsync(comicIdentifier: comicIdentifier);

        _logger.LogWarning(message: "[{DateTime.Now}]: End Querying On Review Comic Table", args: DateTime.Now);

        return _mapper.Map<IEnumerable<ReviewComicModel>>(source: reviewComic);
    }
}
