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

	public async Task<IList<ReviewChapterEntity>> GetChapterReviewsOfAChapterAsync(Guid chapterIdentifier)
	{
		return await _dbSet
			.Where(predicate: reviewChapterEntity
				=> reviewChapterEntity.ChapterIdentifier == chapterIdentifier)
			.Select(selector: reviewChapterEntity => new ReviewChapterEntity
			{
				UserEntity = new()
				{
					Username = reviewChapterEntity.UserEntity.Username,
					UserAvatar = reviewChapterEntity.UserEntity.UserAvatar
				},
				ChapterComment = reviewChapterEntity.ChapterComment,
				ChapterRatingStar = reviewChapterEntity.ChapterRatingStar,
				ReviewTime = reviewChapterEntity.ReviewTime
			})
			.ToListAsync();
	}
}
