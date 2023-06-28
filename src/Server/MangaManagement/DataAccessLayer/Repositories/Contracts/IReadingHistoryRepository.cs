using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IReadingHistoryRepository : IGenericRepository<ReadingHistoryEntity>
{
	Task<IList<ReadingHistoryEntity>> GetReadingHistoriesWith_ComicIdAsync();
	Task<int> GetReadingHistoryCountByComicIdAsync(Guid comicIdentifier);
	Task<IList<ReadingHistoryEntity>> GetReadingHistoresWith_LastReadingTime_ChapterNumber_ComicNameByUserIdAsync(Guid userIndentifier);
	Task<IDictionary<Guid, int>> GetReadingHistoryCountOfComicsAsync();
}
