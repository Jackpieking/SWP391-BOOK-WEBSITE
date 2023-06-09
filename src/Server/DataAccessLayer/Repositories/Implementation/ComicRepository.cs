using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repositories.Implementation;

public class ComicRepository : GenericRepository<ComicEntity>, IComicRepository
{
    public ComicRepository(DbSet<ComicEntity> dbSet) : base(dbSet: dbSet)
    {
    }

    public IEnumerable<ComicEntity> GetAllComicWithReviewComicFromDatabase()
    {
        return _dbSet
            .AsSplitQuery()
            .Select(comicEntity => new ComicEntity
            {
                ComicIdentifier = comicEntity.ComicIdentifier,
                ComicName = comicEntity.ComicName,
                ComicLatestChapter = comicEntity.ComicLatestChapter,
                ComicAvatar = comicEntity.ComicAvatar,
                ReviewComicEntities = comicEntity.ReviewComicEntities
                    .Select(reviewComic => new ReviewComicEntity { }),
            })
            .AsEnumerable();
    }
}
