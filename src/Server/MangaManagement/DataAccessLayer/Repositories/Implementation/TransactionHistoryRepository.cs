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

    public async Task<IList<TransactionsHistoryEntity>> GetAllTransactionHistoryAsync()
    {
        return await _dbSet
            .Select(transactionHistory => new TransactionsHistoryEntity
            {
                UserIdentifier = transactionHistory.UserIdentifier,
                TransactionAmount = transactionHistory.TransactionAmount,
                TransactionDate = transactionHistory.TransactionDate,
                TransactionCoin = transactionHistory.TransactionCoin,
                UserEntity = new()
                {
                    Username = transactionHistory.UserEntity.Username,
                }
            })
            .ToListAsync();

    }

    public async Task<IList<TransactionsHistoryEntity>> GetTransactionHistoriesOfAUserByUserId(Guid userId)
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
