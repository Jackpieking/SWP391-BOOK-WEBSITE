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

    /// <summary>
    /// Select from "Chapter" table these fields:
    /// - ChapterIdentifier
    /// - ChapterNumber
    /// - ChapterUnlockPrice
    /// - AddedDate
    /// </summary>
    /// <returns>IEnumerable<ComicEntity></returns>
    public async Task<IEnumerable<ChapterEntity>> GetAllChapterOfAComicAsync(Guid comicIdentifier)
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
