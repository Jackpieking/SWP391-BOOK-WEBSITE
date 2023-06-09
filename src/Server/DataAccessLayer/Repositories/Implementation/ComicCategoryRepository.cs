using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class ComicCategoryRepository : GenericRepository<ComicCategoryEntity>, IComicCategoryRepository
{
    public ComicCategoryRepository(DbSet<ComicCategoryEntity> dbSet) : base(dbSet: dbSet)
    {
    }
}
