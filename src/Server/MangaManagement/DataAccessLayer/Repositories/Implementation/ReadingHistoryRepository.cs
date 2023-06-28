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

	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
	public async Task<IList<ReadingHistoryEntity>> GetReadingHistoriesWith_ComicIdAsync()
		=> await _dbSet
			.Select(selector: readingHistoryEntity => new ReadingHistoryEntity
			{
				ChapterEntity = new()
				{
					ComicIdentifier = readingHistoryEntity.ChapterEntity.ComicIdentifier
				}
			})
			.ToListAsync();

	/// <summary>
	///
	/// </summary>
	/// <param name="comicIdentifier"></param>
	/// <returns></returns>
	public async Task<int> GetReadingHistoryCountByComicIdAsync(Guid comicIdentifier)
		=> await _dbSet
			.Where(predicate: readingHistoryEntity
				=> readingHistoryEntity.ChapterEntity.ComicIdentifier == comicIdentifier)
			.Select(selector: readingHistoryEntity => new ReadingHistoryEntity
			{
				ChapterIdentifier = readingHistoryEntity.ChapterIdentifier
			})
			.CountAsync();

	/// <summary>
	///
	/// </summary>
	/// <param name="userIndentifier"></param>
	/// <returns></returns>
	public async Task<IList<ReadingHistoryEntity>> GetReadingHistoresWith_LastReadingTime_ChapterNumber_ComicNameByUserIdAsync(Guid userIndentifier)
		=> await _dbSet
			.Where(predicate: reeadingHistoryEntity => reeadingHistoryEntity.UserIdentifier.Equals(userIndentifier))
			.Select(selector: reeadingHistoryEntity => new ReadingHistoryEntity
			{
				LastReadingTime = reeadingHistoryEntity.LastReadingTime,
				ChapterEntity = new ChapterEntity()
				{
					ChapterNumber = reeadingHistoryEntity.ChapterEntity.ChapterNumber,
					ComicEntity = new ComicEntity()
					{
						ComicName = reeadingHistoryEntity.ChapterEntity.ComicEntity.ComicName
					}
				}
			}).ToListAsync();

	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
	public async Task<IDictionary<Guid, int>> GetReadingHistoryCountOfComicsAsync()
	{
		var queryResult = from readingHistoryEntity in _dbSet
						  group readingHistoryEntity by readingHistoryEntity.ChapterEntity.ComicIdentifier
						  into result
						  select new
						  {
							  ComicIdentifier = result.Key,
							  ComicIdentifierCount = result.Count()
						  };

		return await queryResult.ToDictionaryAsync(
			keySelector: res => res.ComicIdentifier,
			elementSelector: res => res.ComicIdentifierCount);
	}
}
