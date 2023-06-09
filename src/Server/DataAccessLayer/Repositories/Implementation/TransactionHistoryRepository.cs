﻿using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class TransactionHistoryRepository : GenericRepository<TransactionsHistoryEntity>, ITransactionRepository
{
    public TransactionHistoryRepository(DbSet<TransactionsHistoryEntity> dbSet) : base(dbSet: dbSet)
    {
    }
}
