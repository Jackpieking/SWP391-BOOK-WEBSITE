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

    public async Task<IList<ReviewComicEntity>> GetAllReviewComicsWith_ComicRatingStar_ComicComment_ReviewTime_Username_UserAvatarByComicIdentifierAsync(Guid comicIdentifier)
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

    public async Task<IList<ReviewComicEntity>> GetAllReviewComicsWith_ComicIdentifier_ReviewTimeAsync()
    {
        return await _dbSet
            .Select(selector: reviewComic => new ReviewComicEntity
            {
                ComicIdentifier = reviewComic.ComicIdentifier,
                ReviewTime = reviewComic.ReviewTime
            })
            .OrderByDescending(keySelector: reviewComicModel => reviewComicModel.ComicIdentifier)
            .ThenByDescending(keySelector: reviewComicModel => reviewComicModel.ReviewTime)
            .ToListAsync();
    }

    public async Task<IList<ReviewComicEntity>> GetComicReviewsOfAUserByUserId(Guid userId)
    {
        return await _dbSet
            .Where(predicate: reviewComic => reviewComic.UserIdentifier.Equals(userId))
            .Select(reviewComic => new ReviewComicEntity
            {
                ComicEntity = new ComicEntity()
                {
                    ComicName = reviewComic.ComicEntity.ComicName
                },
                ComicComment = reviewComic.ComicComment,
                ComicRatingStar = reviewComic.ComicRatingStar,
                ReviewTime = reviewComic.ReviewTime,
                ComicIdentifier = reviewComic.ComicIdentifier
            })
            .ToListAsync();
    }

    public async Task DeleteReviewedOnComic_OfAUser_ByUserIdAsync(Guid userId, Guid comicId)
    {
        ReviewComicEntity comicReviewNeedToDelete = await _dbSet.FindAsync(userId, comicId);
        _dbSet.Remove(comicReviewNeedToDelete);
    }

}
