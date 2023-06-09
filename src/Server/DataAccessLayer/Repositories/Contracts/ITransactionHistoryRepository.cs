using DataAccessLayer.Repositories.Contracts.Base;
using Entity;

namespace DataAccessLayer.Repositories.Contracts;

public interface ITransactionRepository : IGenericRepository<TransactionsHistoryEntity>
{
}
