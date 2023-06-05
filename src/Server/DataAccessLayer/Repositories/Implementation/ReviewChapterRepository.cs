using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class ReviewChapterRepository : GenericRepository<ReviewChapter>, IReviewChapterRepository
{
	public ReviewChapterRepository(DbSet<ReviewChapter> dbSet) : base(dbSet)
	{
	}
}
