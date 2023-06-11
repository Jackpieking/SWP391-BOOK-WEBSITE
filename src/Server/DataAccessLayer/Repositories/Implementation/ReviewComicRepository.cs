using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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
    public IEnumerable<ReviewComicEntity> GetAllReviewComicByComicIdentifierFromDatabase(Guid comicIdentifier)
    {
        return _dbSet
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
            .AsEnumerable();
    }

    /// <summary>
    /// Select from "ReviewComic" table these fields:
    /// - ComicIdentifier
    /// - ReviewTime
    /// </summary>
    /// <returns>IEnumerable<ReviewComicEntity></returns>
    public IEnumerable<ReviewComicEntity> GetAllReviewComicFromDatabase()
    {
        return _dbSet
            .Select(selector: reviewComic => new ReviewComicEntity
            {
                ComicIdentifier = reviewComic.ComicIdentifier,
                ReviewTime = reviewComic.ReviewTime
            })
            .AsEnumerable();
    }
}
