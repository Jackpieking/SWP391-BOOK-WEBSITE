using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts.Base
{
    public interface IComicLikeRepository : IGenericRepository<ComicLikeEntity>
    {
        Task<IEnumerable<ComicLikeEntity>> GetComicLikesAndComicByUserIdAsync(Guid userId);
    }
}