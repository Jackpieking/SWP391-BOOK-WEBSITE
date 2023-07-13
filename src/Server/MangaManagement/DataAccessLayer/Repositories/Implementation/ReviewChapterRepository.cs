﻿using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementation;

public class ReviewChapterRepository : GenericRepository<ReviewChapterEntity>, IReviewChapterRepository
{
    public ReviewChapterRepository(DbSet<ReviewChapterEntity> dbSet) : base(dbSet: dbSet)
    {
    }

    public async Task DeleteReviewedOnChapter_OfAUser_ByUserIdAsync(Guid userId, Guid chapterId)
    {
        var chapterReviewNeedToDelete = await _dbSet.FindAsync(userId, chapterId);
        _dbSet.Remove(chapterReviewNeedToDelete);
    }

    public async Task<IList<ReviewChapterEntity>> GetChapterReviewsOfAChapterAsync(Guid chapterIdentifier)
    {
        return await _dbSet
            .Where(predicate: reviewChapterEntity
                => reviewChapterEntity.ChapterIdentifier == chapterIdentifier)
            .Select(selector: reviewChapterEntity => new ReviewChapterEntity
            {
                UserEntity = new UserEntity()
                {
                    Username = reviewChapterEntity.UserEntity.Username,
                    UserAvatar = reviewChapterEntity.UserEntity.UserAvatar
                },
                ChapterComment = reviewChapterEntity.ChapterComment,
                ChapterRatingStar = reviewChapterEntity.ChapterRatingStar,
                ReviewTime = reviewChapterEntity.ReviewTime
            })
            .OrderBy(reviewChapterEntity => reviewChapterEntity.ReviewTime)
            .ToListAsync();
    }

    public async Task<IList<ReviewChapterEntity>> GetChapterReviewsOfAUserByUserId(Guid userId)
    {
        return await _dbSet
            .Where(reviewChapter => reviewChapter.UserIdentifier.Equals(userId))
            .Select(selector: reviewChapter => new ReviewChapterEntity()
            {
                ChapterEntity = new ChapterEntity()
                {
                    ChapterNumber = reviewChapter.ChapterEntity.ChapterNumber,
                    ComicEntity = new ComicEntity()
                    {
                        ComicName = reviewChapter.ChapterEntity.ComicEntity.ComicName,
                    }
                },
                ChapterComment = reviewChapter.ChapterComment,
                ChapterRatingStar = reviewChapter.ChapterRatingStar,
                ReviewTime = reviewChapter.ReviewTime,
                ChapterIdentifier = reviewChapter.ChapterIdentifier
            })
            .OrderBy(reviewChaper => reviewChaper.ReviewTime)
            .ToListAsync();
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="chapterIdentifier"></param>
    /// <returns></returns>
    public async Task<IEnumerable<ReviewChapterEntity>> GetChapterReviewsWith_Username_UserAvatar_ChapterComment_ChapterRatingStars_ReviewTimeByChapterIdAsync(Guid chapterIdentifier)
    {
        return await _dbSet
            .Where(predicate: reviewChapterEntity
                => reviewChapterEntity.ChapterIdentifier == chapterIdentifier)
            .Select(selector: reviewChapterEntity => new ReviewChapterEntity
            {
                UserEntity = new UserEntity()
                {
                    Username = reviewChapterEntity.UserEntity.Username,
                    UserAvatar = reviewChapterEntity.UserEntity.UserAvatar
                },
                ChapterComment = reviewChapterEntity.ChapterComment,
                ChapterRatingStar = reviewChapterEntity.ChapterRatingStar,
                ReviewTime = reviewChapterEntity.ReviewTime
            })
            .OrderBy(reviewChapterEntity => reviewChapterEntity.ReviewTime)
            .ToListAsync();
    }
}