using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class ChapterImageRepository : GenericRepository<ChapterImage>, IChapterImageRepository
{
	protected ChapterImageRepository(DbSet<ChapterImage> dbSet) : base(dbSet)
	{
	}
}
