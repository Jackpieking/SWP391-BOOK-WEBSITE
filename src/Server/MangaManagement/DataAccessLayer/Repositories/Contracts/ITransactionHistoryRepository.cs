using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface ITransactionRepository : IGenericRepository<TransactionsHistoryEntity>
{
	Task<IList<TransactionsHistoryEntity>> GetTransactionHistoriesWith_TransactionAmount_TransactionDate_TransactionCointByUserIdAsync(Guid userId);

}
