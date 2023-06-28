using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementation;

public class TransactionHistoryRepository : GenericRepository<TransactionsHistoryEntity>, ITransactionRepository
{
	public TransactionHistoryRepository(DbSet<TransactionsHistoryEntity> dbSet) : base(dbSet: dbSet)
	{
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="userId"></param>
	/// <returns></returns>
	public async Task<IList<TransactionsHistoryEntity>> GetTransactionHistoriesWith_TransactionAmount_TransactionDate_TransactionCointByUserIdAsync(Guid userId)
	{
		return await _dbSet
			.Where(transactionHistory => transactionHistory.TransactionIdentifier.Equals(userId))
			.Select(transactionHistory => new TransactionsHistoryEntity
			{
				TransactionAmount = transactionHistory.TransactionAmount,
				TransactionDate = transactionHistory.TransactionDate,
				TransactionCoin = transactionHistory.TransactionCoin
			})
			.ToListAsync();
	}

}
