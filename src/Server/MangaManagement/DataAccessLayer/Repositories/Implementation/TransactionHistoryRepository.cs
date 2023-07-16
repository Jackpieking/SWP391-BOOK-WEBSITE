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

    public async Task<IEnumerable<TransactionsHistoryEntity>> GetTransactionsByUserId(Guid userId) =>
        await _dbSet.Where(e => e.UserIdentifier == userId)
            .OrderBy(e => e.TransactionDate)
            .ToListAsync();
}
