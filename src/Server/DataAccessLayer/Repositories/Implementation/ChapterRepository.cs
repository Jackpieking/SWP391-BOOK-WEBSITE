using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class ChapterRepository : GenericRepository<Chapter>, IChapterRepository
{
	protected ChapterRepository(DbSet<Chapter> dbSet) : base(dbSet)
	{
	}
}
