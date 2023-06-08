using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementation;

public class ComicRepository : GenericRepository<Comic>, IComicRepository
{
    public ComicRepository(DbSet<Comic> dbSet) : base(dbSet)
    {
    }

    public async Task<IEnumerable<Comic>> GetAllComicAsync()
        => await _dbSet.ToListAsync();
}
