using BusinessLogicLayer.Services.Contracts;
using DataAccessLayer.UnitOfWorks.Contracts;
using MangaManagementAPI.Models;
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
                Name = comic.Name,
                Description = comic.Description,
                Avatar = comic.Avatar,
                PublishDate = comic.PublishDate,
                LatestChapter = comic.LatestChapter
            });

    }
}
