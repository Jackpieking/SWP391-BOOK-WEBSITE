using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class ComicRepository : GenericRepository<Comic>, IComicRepository
{
	public ComicRepository(DbSet<Comic> dbSet) : base(dbSet)
	{
	}
}
