﻿using DataAccessLayer.Repositories.Contracts;
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

    public IEnumerable<ReadingHistoryEntity> GetAllReadingHistoryWithChapterWithComicFromDatabase()
    {
        return _dbSet
            .Select(readingHistoryEntity => new ReadingHistoryEntity
            {
                ChapterIdentifier = readingHistoryEntity.ChapterIdentifier,
                ChapterEntity = readingHistoryEntity.ChapterEntity
            })
            .AsEnumerable();
    }
}
