using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Repositories.Contracts;

public interface IReadingHistoryRepository : IGenericRepository<ReadingHistoryEntity>
{
    IEnumerable<ReadingHistoryEntity> GetAllReadingHistoryWithChapterFromDatabase();
    IEnumerable<ReadingHistoryEntity> GetAllReadingHistoryByComicIdentiferFromDatabase(Guid comicIdentifier);
}
