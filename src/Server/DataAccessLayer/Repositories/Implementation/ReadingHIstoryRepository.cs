using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repositories.Implementation;

public class ReadingHistoryRepository : GenericRepository<ReadingHistoryEntity>, IReadingHistoryRepository
{
    public ReadingHistoryRepository(DbSet<ReadingHistoryEntity> dbSet) : base(dbSet: dbSet)
    {
    }

    /// <summary>
    /// Select from "ReadingHistory" table these fields:
    /// - All field from "Chapter" table
    /// </summary>
    /// <returns>IEnumerable<ReadingHistoryEntity></returns>
    public IEnumerable<ReadingHistoryEntity> GetAllReadingHistoryWithChapterWithComicFromDatabase()
    {
        return _dbSet
            .Select(selector: readingHistoryEntity => new ReadingHistoryEntity
            {
                ChapterEntity = readingHistoryEntity.ChapterEntity
            })
            .AsEnumerable();
    }
}
