using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class PublisherRepository : GenericRepository<PublisherEntity>, IPublisherRepository
{
    public PublisherRepository(DbSet<PublisherEntity> dbSet) : base(dbSet: dbSet)
    {
    }
}
