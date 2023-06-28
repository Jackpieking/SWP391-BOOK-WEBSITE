using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IReviewChapterRepository : IGenericRepository<ReviewChapterEntity>
{
	Task<IList<ReviewChapterEntity>> GetChapterReviewsByChapterIdAsync(Guid chapterIdentifier);
	Task<IList<ReviewChapterEntity>> GetChapterReviewsWith_ChapterNumber_ComicName_ChapterComment_ChapterRatingStar_ReviewTimeByUserIdAsync(Guid userId);
	Task<IEnumerable<ReviewChapterEntity>> GetChapterReviewsWith_Username_UserAvatar_ChapterComment_ChapterRatingStars_ReviewTimeByChapterIdAsync(Guid chapterIdentifier);
}
