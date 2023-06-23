using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Repositories.Contracts.Base;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation
{
    public class ComicLikeRepository : GenericRepository<ComicLikeEntity>, IComicLikeRepository
    {
        public ComicLikeRepository(DbSet<ComicLikeEntity> dbSet) : base(dbSet)
        {
        }

        public async Task<IList<ComicLikeEntity>> GetComicLikesOfAUserByUserId(Guid userId)
        {
            return await _dbSet
                .Where(comicLike => comicLike.UserIdentifier.Equals(userId))
                .Select(comicLike => new ComicLikeEntity 
                {
                    ComicEntity = new ComicEntity
                    {
                        ComicAvatar = comicLike.ComicEntity.ComicAvatar,
                        ComicName = comicLike.ComicEntity.ComicName
                    }
                })
                .ToListAsync();
        }
    }
}