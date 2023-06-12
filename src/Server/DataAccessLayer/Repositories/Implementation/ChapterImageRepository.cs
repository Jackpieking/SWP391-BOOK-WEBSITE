﻿using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementation;

public class ChapterImageRepository : GenericRepository<ChapterImageEntity>, IChapterImageRepository
{
    public ChapterImageRepository(DbSet<ChapterImageEntity> dbSet) : base(dbSet: dbSet)
    {
    }

    /// <summary>
    /// Select from "ChapterImage" table these fields:
    /// - ImageURL
    /// - ImageNumber
    /// </summary>
    /// <returns>IEnumerable<ComicEntity></returns>
    public async Task<IEnumerable<ChapterImageEntity>> GetAllChapterImageOfAChapterFromDatabaseAsync(Guid chapterIdentifier)
    {
        return await _dbSet
            .Where(predicate: predicate
                => predicate.ChapterIdentifier == chapterIdentifier)
            .Select(selector: chapterImage => new ChapterImageEntity
            {
                ImageNumber = chapterImage.ImageNumber,
                ImageURL = chapterImage.ImageURL
            })
            .OrderBy(keySelector: chapterImage
                => chapterImage.ImageNumber)
            .ToListAsync();
    }
}
