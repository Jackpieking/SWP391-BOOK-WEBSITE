using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class ChapterImageRepository : GenericRepository<ChapterImageEntity>, IChapterImageRepository
{
    public ChapterImageRepository(DbSet<ChapterImageEntity> dbSet) : base(dbSet: dbSet)
    {
    }
}
