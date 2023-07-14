using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Helper;
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
    ///
    /// </summary>
    /// <param name="chapterIdentifier"></param>
    /// <returns></returns>
    public async Task<ChapterEntity> GetChapterWithComicByChapterIdentifierFromDatabaseAsync(Guid chapterIdentifier)
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

    /// <summary>
    ///
    /// </summary>
    /// <param name="comicIdentifier"></param>
    /// <returns></returns>
    public async Task<IList<ChapterEntity>> GetChapterWith_ChapterIdentifier_ChapterNumber_ChapterUnlockPrice_ChapterAddedDateAsync(Guid comicIdentifier)
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
            .OrderByDescending(keySelector: chapterEntity => chapterEntity.ChapterNumber)
            .ToListAsync();
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="crawlChapterEntities"></param>
    /// <returns></returns>
    public async Task UpdateCrawlDataAsync(
        IList<ChapterEntity> crawlChapterEntities,
        Guid comicIdentifier)
    {
        crawlChapterEntities.ForEach(action: crawlChapterEntity =>
        {
            crawlChapterEntity.ComicIdentifier = comicIdentifier;
        });

        //get list of chapter of a specific comic by comic name
        var chapterEntities = _dbSet.
            Where(predicate: chapterEntity
                => chapterEntity.ComicIdentifier.Equals(comicIdentifier))
            .Select(chapterEntity => new ChapterEntity
            {
                ChapterIdentifier = chapterEntity.ChapterIdentifier,
            });

        //comic does not have any chapter
        if (!await chapterEntities.AnyAsync())
        {
            await _dbSet.AddRangeAsync(entities: crawlChapterEntities);

            return;
        }

        foreach (var crawlChapterEntity in crawlChapterEntities)
        {
            //check if chapter have been existed
            var foundChapterEntity = chapterEntities
                .FirstOrDefault(chapterEntity
                    => chapterEntity.ChapterNumber.Equals(crawlChapterEntity.ChapterNumber));

            //if chapter is not existed
            if (Equals(objA: foundChapterEntity, objB: null))
            {
                await _dbSet.AddAsync(entity: crawlChapterEntity);
            }
        }
    }

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public async Task<IEnumerable<ChapterEntity>> GetAllChapterWith_ChapterNumber_ComicIdentitiferAsync()
    {
        return await _dbSet
            .Select(selector: chapterEntity => new ChapterEntity
            {
                ComicIdentifier = chapterEntity.ComicIdentifier,
                ChapterNumber = chapterEntity.ChapterNumber
            })
            .OrderByDescending(keySelector: chapterEntity => chapterEntity.ComicIdentifier)
            .ThenByDescending(keySelector: chapterEntity => chapterEntity.ChapterNumber)
            .ToListAsync();
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="chapterIdentifier"></param>
    /// <returns></returns>
    public async Task<ChapterEntity> GetChapterWith_ComicIdByChapterIdAsync(Guid chapterIdentifier)
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

    public async Task<IList<ChapterEntity>> GetChaptersWith_ChapterId_ChapterNumberByComicNameAsync(string comicName)
    {
        return await _dbSet
            .Where(predicate: chapterEntity => chapterEntity.ComicEntity.ComicName.Equals(comicName))
            .OrderBy(keySelector: chapterEntity => chapterEntity.ChapterNumber)
            .Select(selector: chapterEntity => new ChapterEntity
            {
                ChapterNumber = chapterEntity.ChapterNumber,
                ChapterIdentifier = chapterEntity.ChapterIdentifier
            })
            .ToListAsync();
    }

    public async Task<ChapterEntity> GetChapterByIdAsync(Guid id) =>
        await _dbSet.FirstOrDefaultAsync(c => c.ChapterIdentifier == id);
}
