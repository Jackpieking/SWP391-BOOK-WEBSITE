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

    /// <summary>
    /// /// Select from "ReviewComic" table these fields:
    /// - ComicIdentifier
    /// - ComicRatingStar
    /// Requirement: equal to given comicIdentifier
    /// </summary>
    /// <param name="comicIdentifier"></param>
    /// <returns>IEnumerable<ReviewComicEntity></returns>
    public async Task<IEnumerable<ReviewComicEntity>> GetAllReviewComicByComicIdentifierFromDatabaseAsync(Guid comicIdentifier)
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

    /// <summary>
    /// Select from "ReviewComic" table these fields:
    /// - ComicIdentifier
    /// - ReviewTime
    /// </summary>
    /// <returns>IEnumerable<ReviewComicEntity></returns>
    public async Task<IEnumerable<ReviewComicEntity>> GetAllReviewComicFromDatabaseAsync()
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
