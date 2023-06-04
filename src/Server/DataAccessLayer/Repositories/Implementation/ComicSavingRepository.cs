using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class ComicSavingRepository : GenericRepository<ComicSaving>, IComicSavingRepository
{
	protected ComicSavingRepository(DbSet<ComicSaving> dbSet) : base(dbSet)
	{
	}
}
