using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class ComicCategoryRepository : GenericRepository<ComicCategory>, IComicCategoryRepository
{
	public ComicCategoryRepository(DbSet<ComicCategory> dbSet) : base(dbSet)
	{
	}
}
