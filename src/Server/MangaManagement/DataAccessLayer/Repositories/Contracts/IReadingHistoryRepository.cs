using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IReadingHistoryRepository : IGenericRepository<ReadingHistoryEntity>
{
    Task<IList<ReadingHistoryEntity>> GetAllReadingHistoriesWith_ChapterIdentifierAsync();
    Task<int> GetReadingHistoryCountWith_ChapterIdentifierByComicIdentiferAsync(Guid comicIdentifier);
<<<<<<< HEAD
=======
    Task<IList<ReadingHistoryEntity>> GetAllReadingHistoresOfAUserByUserId(Guid userIndentifier);
>>>>>>> c86f98a6ee0d041c58490069b911605912b072b6
}
