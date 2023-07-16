using DataAccessLayer.Repositories.Contracts.Base;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementation;

public class ComicLikeRepository : GenericRepository<ComicLikeEntity>, IComicLikeRepository
{
    public ComicLikeRepository(DbSet<ComicLikeEntity> dbSet) : base(dbSet)
    {
    }

    public async Task<IEnumerable<ComicLikeEntity>> GetComicLikesAndComicByUserIdAsync(Guid userId)
    {
        var comicLikes = await _dbSet.Where(e => e.UserIdentifier == userId).ToListAsync();

        foreach (var comic in comicLikes)
        {
            await _dbSet.Entry(comic).Reference(e => e.ComicEntity).LoadAsync();
        }

        return comicLikes;
    }
}