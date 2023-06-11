using AutoMapper;
using DataAccessLayer.UnitOfWorks.Contracts;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Collections.Generic;

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
    public IEnumerable<ReviewComicModel> GetAllReviewComic()
    {
        _logger.LogCritical(message: "[{DateTime.Now}]: Start Querying On Review Comic Table", args: DateTime.Now);

        var reviewComic = _unitOfWork
            .ReviewComicRepository
            .GetAllReviewComicFromDatabase();

        _logger.LogCritical(message: "[{DateTime.Now}]: End Querying On Review Comic Table", args: DateTime.Now);

        return _mapper.Map<IEnumerable<ReviewComicModel>>(source: reviewComic);
    }

    /// <summary>
    /// Get all review comic by comicIdentifier without any reference from the database
    /// </summary>
    /// <param name="comicIdentifier"></param>
    /// <returns>IEnumerable<ReviewComicModel></returns>
    public IEnumerable<ReviewComicModel> GetAllReviewComicByComicIdentifier(Guid comicIdentifier)
    {
        _logger.LogCritical(message: "[{DateTime.Now}]: Start Querying On Review Comic Table", args: DateTime.Now);

        var reviewComic = _unitOfWork
            .ReviewComicRepository
            .GetAllReviewComicByComicIdentifierFromDatabase(comicIdentifier: comicIdentifier);

        _logger.LogCritical(message: "[{DateTime.Now}]: End Querying On Review Comic Table", args: DateTime.Now);

        return _mapper.Map<IEnumerable<ReviewComicModel>>(source: reviewComic);
    }
}
