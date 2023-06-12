﻿using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IReadingHistoryRepository : IGenericRepository<ReadingHistoryEntity>
{
    Task<IEnumerable<ReadingHistoryEntity>> GetAllReadingHistoryWithChapterFromDatabaseAsync();
    Task<IEnumerable<ReadingHistoryEntity>> GetAllReadingHistoryByComicIdentiferFromDatabaseAsync(Guid comicIdentifier);
}
