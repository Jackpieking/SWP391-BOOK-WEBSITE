﻿using DataAccessLayer.Repositories.Contracts.Base;
using DataAccessLayer.Data.Entites;

namespace DataAccessLayer.Repositories.Contracts;

public interface ITransactionRepository : IGenericRepository<TransactionsHistoryEntity>
{
}
