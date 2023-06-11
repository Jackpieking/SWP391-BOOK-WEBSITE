using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

    /// <summary>
    /// Select from "comic" table with these fields:
    /// - all field from "comic" table
    /// Requirement: equal to given comicIdentifier
    /// </summary>
    /// <param name="comicIdentifier"></param>
    /// <returns>Task<ComicEntity></returns>
    public async Task<ComicEntity> GetComicByComicIdentifierDatabaseAsync(Guid comicIdentifier)
    {
        return await _dbSet
            .Where(predicate: comicEntity
                => comicEntity.ComicIdentifier == comicIdentifier)
            .Select(comicEntity => new ComicEntity
            {
                ComicIdentifier = comicIdentifier,
                ComicName = comicEntity.ComicName,
                ComicDescription = comicEntity.ComicDescription,
                ComicAvatar = comicEntity.ComicAvatar,
                ComicPublishDate = comicEntity.ComicPublishDate,
                ComicLatestChapter = comicEntity.ComicLatestChapter,
                PublisherEntity = new()
                {
                    PublisherIdentifier = comicEntity.PublisherIdentifier,
                    UserEntity = comicEntity.PublisherEntity.UserEntity
                }
            })
            .FirstOrDefaultAsync();
    }
}
