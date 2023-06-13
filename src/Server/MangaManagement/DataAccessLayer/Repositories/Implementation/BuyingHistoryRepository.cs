using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class BuyingHistoryRepository : GenericRepository<BuyingHistoryEntity>, IBuyingHistoryRepository
{
    public BuyingHistoryRepository(DbSet<BuyingHistoryEntity> dbSet) : base(dbSet: dbSet)
    {
    }
}
