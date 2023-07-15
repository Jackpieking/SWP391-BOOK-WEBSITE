using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;

namespace DataAccessLayer.Repositories.Contracts.Base
{
    public interface IComicLikeRepository : IGenericRepository<ComicLikeEntity>
    {
        Task<IList<ComicLikeEntity>> GetComicLikesOfAUserByUserId(Guid userId);

        Task<IList<ComicLikeEntity>> GetAllComicLikesAsync();
    }
}