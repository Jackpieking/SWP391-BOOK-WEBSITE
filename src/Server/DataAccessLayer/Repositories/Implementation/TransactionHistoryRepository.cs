using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class TransactionHistoryRepository : GenericRepository<TransactionsHistory>, ITransactionRepository
{
	protected TransactionHistoryRepository(DbSet<TransactionsHistory> dbSet) : base(dbSet)
	{
	}
}
