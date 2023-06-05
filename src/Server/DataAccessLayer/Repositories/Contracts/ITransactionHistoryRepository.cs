﻿using DataAccessLayer.Repositories.Contracts.Base;
using MangaManagementAPI.Data.Entites;

namespace DataAccessLayer.Repositories.Contracts;

public interface ITransactionRepository : IGenericRepository<TransactionsHistory>
{
}
