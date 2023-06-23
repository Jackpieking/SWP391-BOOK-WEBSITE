using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccessLayer.Repositories.Contracts.Base;
using Entity;

namespace DataAccessLayer.Repositories.Contracts;

public interface IBuyingHistoryRepository : IGenericRepository<BuyingHistoryEntity>
{
    Task<IList<BuyingHistoryEntity>> GetBuyingHistoriesOfAUserByUserId(Guid userId);
}
