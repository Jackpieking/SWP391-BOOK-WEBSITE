using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IBuyingHistoryRepository : IGenericRepository<BuyingHistoryEntity>
{
	Task<IList<BuyingHistoryEntity>> GetBuyingHistoriesByUserId(Guid userId);
}
