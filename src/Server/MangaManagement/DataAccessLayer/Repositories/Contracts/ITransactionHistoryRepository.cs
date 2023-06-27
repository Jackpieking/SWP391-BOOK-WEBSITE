using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccessLayer.Repositories.Contracts.Base;
using Entity;

namespace DataAccessLayer.Repositories.Contracts;

public interface ITransactionRepository : IGenericRepository<TransactionsHistoryEntity>
{
    Task<IList<TransactionsHistoryEntity>> GetTransactionHistoriesOfAUserByUserId(Guid userId);

}
