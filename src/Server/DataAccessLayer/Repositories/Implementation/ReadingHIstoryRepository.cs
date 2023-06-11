using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repositories.Implementation;

public class ReadingHistoryRepository : GenericRepository<ReadingHistoryEntity>, IReadingHistoryRepository
{
    public ReadingHistoryRepository(DbSet<ReadingHistoryEntity> dbSet) : base(dbSet: dbSet)
    {
    }

    /// <summary>
    /// /// Select from "ReadingHistory" table these fields:
    /// - ChapterIdentifier
    /// Requirement: equal to given comicIdentifier
    /// </summary>
    /// <param name="comicIdentifier"></param>
    /// <returns>IEnumerable<ReadingHistoryEntity></returns>
    public IEnumerable<ReadingHistoryEntity> GetAllReadingHistoryByComicIdentiferFromDatabase(Guid comicIdentifier)
    {
        return _dbSet
            .Where(predicate: readingHistoryEntity
                => readingHistoryEntity.ChapterEntity.ComicIdentifier == comicIdentifier)
            .Select(selector: readingHistoryEntity => new ReadingHistoryEntity
            {
                ChapterIdentifier = readingHistoryEntity.ChapterIdentifier
            })
            .AsEnumerable();
    }

    /// <summary>
    /// Select from "ReadingHistory" table these fields:
    /// - All field from "Chapter" table
    /// </summary>
    /// <returns>IEnumerable<ReadingHistoryEntity></returns>
    public IEnumerable<ReadingHistoryEntity> GetAllReadingHistoryWithChapterFromDatabase()
    {
        return _dbSet
            .Select(selector: readingHistoryEntity => new ReadingHistoryEntity
            {
                ChapterEntity = readingHistoryEntity.ChapterEntity
            })
            .AsEnumerable();
    }
}
