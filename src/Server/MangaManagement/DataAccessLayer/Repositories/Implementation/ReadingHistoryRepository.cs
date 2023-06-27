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

	public async Task<int> GetReadingHistoryCountByComicIdentiferAsync(Guid comicIdentifier)
	{
		return await _dbSet
			.Where(predicate: readingHistoryEntity
				=> readingHistoryEntity.ChapterEntity.ComicIdentifier == comicIdentifier)
			.Select(selector: readingHistoryEntity => new ReadingHistoryEntity
			{
				ChapterIdentifier = readingHistoryEntity.ChapterIdentifier
			})
			.CountAsync();
	}

<<<<<<< Updated upstream
    public async Task<IList<ReadingHistoryEntity>> GetAllReadingHistoriesWith_ChapterIdentifierAsync()
    {
        return await _dbSet
            .Select(selector: readingHistoryEntity => new ReadingHistoryEntity
            {
                ChapterEntity = new()
                {
                    ComicIdentifier = readingHistoryEntity.ChapterEntity.ComicIdentifier
                }
            })
            .ToListAsync();
    }
<<<<<<< HEAD
=======

    public async Task<IList<ReadingHistoryEntity>> GetAllReadingHistoresOfAUserByUserId(Guid userIndentifier)
    {
        return await _dbSet
            .Where(predicate: reeadingHistoryEntity => reeadingHistoryEntity.UserIdentifier.Equals(userIndentifier))
            .Select( selector: reeadingHistoryEntity => new ReadingHistoryEntity
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
    }
>>>>>>> c86f98a6ee0d041c58490069b911605912b072b6
=======
	public async Task<IList<ReadingHistoryEntity>> GetAllReadingHistoriesWith_ChapterIdentifierAsync()
	{
		return await _dbSet
			.Select(selector: readingHistoryEntity => new ReadingHistoryEntity
			{
				ChapterEntity = new()
				{
					ComicIdentifier = readingHistoryEntity.ChapterEntity.ComicIdentifier
				}
			})
			.ToListAsync();
	}

	public async Task<IDictionary<Guid, int>> GetReadingHistoryCountOfAllComicsAsync()
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
>>>>>>> Stashed changes
}
