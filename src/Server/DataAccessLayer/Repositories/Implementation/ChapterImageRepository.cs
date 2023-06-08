using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using DataAccessLayer.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class ChapterImageRepository : GenericRepository<ChapterImageEntity>, IChapterImageRepository
{
	public ChapterImageRepository(DbSet<ChapterImageEntity> dbSet) : base(dbSet)
	{
	}
}
