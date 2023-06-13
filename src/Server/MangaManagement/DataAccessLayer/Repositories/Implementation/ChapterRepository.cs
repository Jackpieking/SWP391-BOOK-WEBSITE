using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementation;

public class ChapterRepository : GenericRepository<ChapterEntity>, IChapterRepository
{
    public ChapterRepository(DbSet<ChapterEntity> dbSet) : base(dbSet: dbSet)
    {
    }

    public async Task<ChapterEntity> GetAChapterWithComicByChapterIdentifierFromDatabaseAsync(Guid chapterIdentifier)
    {
        return await _dbSet
            .Where(predicate: chapterEntity
                => chapterEntity.ChapterIdentifier == chapterIdentifier)
            .Select(selector: chapterEntity => new ChapterEntity
            {
                ChapterIdentifier = chapterEntity.ChapterIdentifier,
                ChapterNumber = chapterEntity.ChapterNumber,
                ComicEntity = new()
                {
                    ComicName = chapterEntity.ComicEntity.ComicName
                }
            })
            .FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<ChapterEntity>> GetAllChaptersOfAComicFromDatabaseAsync(Guid comicIdentifier)
    {
        return await _dbSet
            .Where(predicate: chapterEntity
                => chapterEntity.ComicIdentifier == comicIdentifier)
            .Select(chapterEntity => new ChapterEntity
            {
                ChapterIdentifier = chapterEntity.ChapterIdentifier,
                ChapterNumber = chapterEntity.ChapterNumber,
                ChapterUnlockPrice = chapterEntity.ChapterUnlockPrice,
                AddedDate = chapterEntity.AddedDate
            })
            .ToListAsync();
    }
}
