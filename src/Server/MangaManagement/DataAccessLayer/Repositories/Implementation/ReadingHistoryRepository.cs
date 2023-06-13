using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementation;

public class ReadingHistoryRepository : GenericRepository<ReadingHistoryEntity>, IReadingHistoryRepository
{
    public ReadingHistoryRepository(DbSet<ReadingHistoryEntity> dbSet) : base(dbSet: dbSet)
    {
    }

    public async Task<IEnumerable<ReadingHistoryEntity>> GetAllReadingHistoriesByComicIdentiferFromDatabaseAsync(Guid comicIdentifier)
    {
        return await _dbSet
            .Where(predicate: readingHistoryEntity
                => readingHistoryEntity.ChapterEntity.ComicIdentifier == comicIdentifier)
            .Select(selector: readingHistoryEntity => new ReadingHistoryEntity
            {
                ChapterIdentifier = readingHistoryEntity.ChapterIdentifier
            })
            .ToListAsync();
    }

    public async Task<IEnumerable<ReadingHistoryEntity>> GetAllReadingHistoriesWithChapterFromDatabaseAsync()
    {
        return await _dbSet
            .Select(selector: readingHistoryEntity => new ReadingHistoryEntity
            {
                ChapterEntity = readingHistoryEntity.ChapterEntity
            })
            .ToListAsync();
    }
}
