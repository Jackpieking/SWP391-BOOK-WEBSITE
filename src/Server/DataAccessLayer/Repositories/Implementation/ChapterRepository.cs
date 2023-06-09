using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class ChapterRepository : GenericRepository<ChapterEntity>, IChapterRepository
{
    public ChapterRepository(DbSet<ChapterEntity> dbSet) : base(dbSet: dbSet)
    {
    }
}
