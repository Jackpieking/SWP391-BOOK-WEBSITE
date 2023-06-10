using AutoMapper;
using DataAccessLayer.UnitOfWorks.Contracts;
using Model;
using System.Collections.Generic;

namespace BusinessLogicLayer.Services;

public class ReviewComicService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ReviewComicService(
        IUnitOfWork unitOfWork,
        IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    /// <summary>
    /// Get all review comic without any reference from the database
    /// </summary>
    /// <returns>IEnumerable<ReviewComicModel></returns>
    public IEnumerable<ReviewComicModel> GetAllReviewComic()
    {
        var reviewComic = _unitOfWork
            .ReviewComicRepository
            .GetReviewComicFromDatabase();

        return _mapper.Map<IEnumerable<ReviewComicModel>>(source: reviewComic);
    }
}
