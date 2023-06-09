using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class ReviewChapterRepository : GenericRepository<ReviewChapterEntity>, IReviewChapterRepository
{
    public ReviewChapterRepository(DbSet<ReviewChapterEntity> dbSet) : base(dbSet: dbSet)
    {
    }
}
