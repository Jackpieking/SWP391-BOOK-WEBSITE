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

    /// <summary>
    /// Select from "comic" table these fields:
    /// - ComicIdentifier
    /// - ComicPublishDate
    /// - ComicName
    /// - ComicLastestChapter
    /// - ComicAvatars
    /// </summary>
    /// <returns>IEnumerable<ComicEntity></returns>
    public IEnumerable<ComicEntity> GetAllComicFromDatabase()
    {
        return _dbSet
            .AsSplitQuery()
            .Select(selector: comicEntity => new ComicEntity
            {
                ComicIdentifier = comicEntity.ComicIdentifier,
                ComicPublishDate = comicEntity.ComicPublishDate,
                ComicName = comicEntity.ComicName,
                ComicLatestChapter = comicEntity.ComicLatestChapter,
                ComicAvatar = comicEntity.ComicAvatar
            })
            .AsEnumerable();
    }
}
