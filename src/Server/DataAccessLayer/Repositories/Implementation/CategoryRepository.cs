using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using DataAccessLayer.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class CategoryRepository : GenericRepository<CategoryEntity>, ICategoryRepository
{
	public CategoryRepository(DbSet<CategoryEntity> dbSet) : base(dbSet)
	{
	}
}
