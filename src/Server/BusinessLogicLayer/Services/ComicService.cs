using AutoMapper;
using DataAccessLayer.UnitOfWorks.Contracts;
using Model;
using System.Collections.Generic;

namespace BusinessLogicLayer.Services;

public class ComicService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ComicService(IUnitOfWork unitOfWork,
                        IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public IEnumerable<ComicModel> GetAllComicWithComicReview()
    {
        var comicJoinReviewComicEntities = _unitOfWork
            .ComicRepository
            .GetAllComicWithReviewComicFromDatabase();

        return _mapper.Map<IEnumerable<ComicModel>>(source: comicJoinReviewComicEntities);

    }
}
