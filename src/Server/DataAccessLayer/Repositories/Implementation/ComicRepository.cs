using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementation;

public class ComicRepository : GenericRepository<ComicEntity>, IComicRepository
{
    public ComicRepository(DbSet<ComicEntity> dbSet) : base(dbSet: dbSet)
    {
    }

    public async Task<IEnumerable<ComicEntity>> GetAllComicAsync()
        => await _dbSet.ToListAsync();
}
