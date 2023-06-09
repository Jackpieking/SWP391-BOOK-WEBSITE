using BusinessLogicLayer.Services.Contracts;
using DataAccessLayer.UnitOfWorks.Contracts;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Implementations;

public class ComicService : IComicService
{
    private readonly IUnitOfWork _unitOfWork;

    public ComicService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<ComicModel>> GetAllComicFromDatabaseAsync()
    {
        var comics = await _unitOfWork
            .ComicRepository
            .GetAllComicAsync();

        return comics
            .Select(selector: comic => new ComicModel
            {
                ComicIdentifier = comic.ComicIdentifier,
                ComicName = comic.ComicName,
                ComicDescription = comic.ComicDescription,
                ComicAvatar = comic.ComicAvatar,
                ComicPublishDate = comic.ComicPublishDate,
                ComicLatestChapter = comic.ComicLatestChapter
            });

    }
}
