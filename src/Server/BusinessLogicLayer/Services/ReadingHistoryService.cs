using AutoMapper;
using DataAccessLayer.UnitOfWorks.Contracts;
using Model;
using System.Collections.Generic;

namespace BusinessLogicLayer.Services;

public class ReadingHistoryService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ReadingHistoryService(
        IUnitOfWork unitOfWork,
        IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    /// <summary>
    /// Get all reading history with reference chapter from database
    /// </summary>
    /// <returns>IEnumerable<ReadingHistoryModel></returns>
    public IEnumerable<ReadingHistoryModel> GetAllReadingHistoryWithChapter()
    {
        var readingHistoryWithChapterEntities = _unitOfWork
            .ReadingHistoryRepository
            .GetAllReadingHistoryWithChapterWithComicFromDatabase();

        return _mapper.Map<IEnumerable<ReadingHistoryModel>>(source: readingHistoryWithChapterEntities);
    }
}
