using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using DataAccessLayer.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class ComicSavingRepository : GenericRepository<ComicSavingEntity>, IComicSavingRepository
{
	public ComicSavingRepository(DbSet<ComicSavingEntity> dbSet) : base(dbSet)
	{
	}
}
