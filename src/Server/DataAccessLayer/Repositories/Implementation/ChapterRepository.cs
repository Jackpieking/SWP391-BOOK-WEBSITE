using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using DataAccessLayer.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class ChapterRepository : GenericRepository<ChapterEntity>, IChapterRepository
{
	public ChapterRepository(DbSet<ChapterEntity> dbSet) : base(dbSet)
	{
	}
}
