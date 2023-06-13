using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementation;

public class ReviewComicRepository : GenericRepository<ReviewComicEntity>, IReviewComicRepository
{
    public ReviewComicRepository(DbSet<ReviewComicEntity> dbSet) : base(dbSet: dbSet)
    {
    }

    public async Task<IEnumerable<ReviewComicEntity>> GetAllReviewComicsByComicIdentifierFromDatabaseAsync(Guid comicIdentifier)
    {
        return await _dbSet
            .Where(predicate: reviewComicEntity
                => reviewComicEntity.ComicIdentifier == comicIdentifier)
            .Select(selector: reviewComicEntity => new ReviewComicEntity
            {
                ComicRatingStar = reviewComicEntity.ComicRatingStar,
                ComicComment = reviewComicEntity.ComicComment,
                ReviewTime = reviewComicEntity.ReviewTime,
                UserEntity = new()
                {
                    Username = reviewComicEntity.UserEntity.Username,
                    UserAvatar = reviewComicEntity.UserEntity.UserAvatar
                }
            })
            .ToListAsync();
    }

    public async Task<IEnumerable<ReviewComicEntity>> GetAllReviewComicsFromDatabaseAsync()
    {
        return await _dbSet
            .Select(selector: reviewComic => new ReviewComicEntity
            {
                ComicIdentifier = reviewComic.ComicIdentifier,
                ReviewTime = reviewComic.ReviewTime
            })
            .ToListAsync();
    }
}
