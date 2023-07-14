using DataAccessLayer.Repositories.Contracts;
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

	public async Task<IList<ReviewChapterEntity>> GetAllChapterReviewAsync()
	{
		return await _dbSet
			.Select(chapterReview => new ReviewChapterEntity
			{
				UserIdentifier = chapterReview.UserIdentifier,
				ChapterIdentifier = chapterReview.ChapterIdentifier,
				ChapterComment = chapterReview.ChapterComment,
				ChapterRatingStar = chapterReview.ChapterRatingStar,
				ReviewTime = chapterReview.ReviewTime,
				ChapterEntity = new ChapterEntity
				{
					ChapterNumber = chapterReview.ChapterEntity.ChapterNumber,
					ComicEntity = new ComicEntity
					{
						ComicName = chapterReview.ChapterEntity.ComicEntity.ComicName
					}
				},
				UserEntity = new UserEntity
				{
					Username = chapterReview.UserEntity.Username
				},
			})
			.ToListAsync();
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
				ChapterIdentifier = reviewChapter.ChapterIdentifier,
				UserIdentifier = reviewChapter.UserIdentifier,
				UserEntity = new UserEntity
				{
					Username = reviewChapter.UserEntity.Username
				}
			})
			.OrderBy(reviewChaper => reviewChaper.ReviewTime)
			.ToListAsync();
	}
}