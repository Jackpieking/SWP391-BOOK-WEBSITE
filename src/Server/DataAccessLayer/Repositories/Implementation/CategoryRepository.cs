using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
	public CategoryRepository(DbSet<Category> dbSet) : base(dbSet)
	{
	}
}
