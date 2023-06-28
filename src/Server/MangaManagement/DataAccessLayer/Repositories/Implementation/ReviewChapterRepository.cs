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

	/// <summary>
	///
	/// </summary>
	/// <param name="chapterIdentifier"></param>
	/// <returns></returns>
	/// <exception cref="NotImplementedException"></exception>
	public Task<IList<ReviewChapterEntity>> GetChapterReviewsByChapterIdAsync(Guid chapterIdentifier)
	{
		throw new NotImplementedException();
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="userId"></param>
	/// <returns></returns>
	public async Task<IList<ReviewChapterEntity>> GetChapterReviewsWith_ChapterNumber_ComicName_ChapterComment_ChapterRatingStar_ReviewTimeByUserIdAsync(Guid userId)
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
						ComicName = reviewChapter.ChapterEntity.ComicEntity.ComicName
					}
				},
				ChapterComment = reviewChapter.ChapterComment,
				ChapterRatingStar = reviewChapter.ChapterRatingStar,
				ReviewTime = reviewChapter.ReviewTime
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
