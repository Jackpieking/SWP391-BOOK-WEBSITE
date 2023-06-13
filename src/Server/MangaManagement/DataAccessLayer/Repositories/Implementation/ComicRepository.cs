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

    public async Task<IEnumerable<ComicEntity>> GetAllComicsFromDatabaseAsync()
    {
        return await _dbSet
            .Select(selector: comicEntity => new ComicEntity
            {
                ComicIdentifier = comicEntity.ComicIdentifier,
                ComicPublishedDate = comicEntity.ComicPublishedDate,
                ComicName = comicEntity.ComicName,
                ComicLatestChapter = comicEntity.ComicLatestChapter,
                ComicAvatar = comicEntity.ComicAvatar
            })
            .ToListAsync();
    }

    public async Task<ComicEntity> GetComicWithChapterListByComicIdentifierDatabaseAsync(Guid comicIdentifier)
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
                ComicPublishedDate = comicEntity.ComicPublishedDate,
                ComicLatestChapter = comicEntity.ComicLatestChapter,
                PublisherEntity = new()
                {
                    PublisherIdentifier = comicEntity.PublisherIdentifier,
                    UserEntity = new()
                    {
                        Username = comicEntity
                            .PublisherEntity
                            .UserEntity
                            .Username
                    }
                }
            })
            .FirstOrDefaultAsync();
    }
}
