using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementation;

public class BuyingHistoryRepository : GenericRepository<BuyingHistoryEntity>, IBuyingHistoryRepository
{
	public BuyingHistoryRepository(DbSet<BuyingHistoryEntity> dbSet) : base(dbSet: dbSet)
	{
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="userId"></param>
	/// <returns></returns>
	public async Task<IList<BuyingHistoryEntity>> GetBuyingHistoriesByUserId(Guid userId)
	{
		return await _dbSet
			.Where(buyingHistories => buyingHistories.UserIdentifier.Equals(userId))
			.Select(buyingHistories => new BuyingHistoryEntity
			{
				ChapterEntity = new ChapterEntity()
				{
					ChapterNumber = buyingHistories.ChapterEntity.ChapterNumber,
					ChapterUnlockPrice = buyingHistories.ChapterEntity.ChapterUnlockPrice,
					ComicEntity = new ComicEntity()
					{
						ComicName = buyingHistories.ChapterEntity.ComicEntity.ComicName
					}
				},
				BuyingDate = buyingHistories.BuyingDate

			})
			.OrderBy(buyingHistory => buyingHistory.BuyingDate)
			.ToListAsync();
	}

}
