using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class ReviewComicRepository : GenericRepository<ReviewComic>, IReviewComicRepository
{
	protected ReviewComicRepository(DbSet<ReviewComic> dbSet) : base(dbSet)
	{
	}
}
