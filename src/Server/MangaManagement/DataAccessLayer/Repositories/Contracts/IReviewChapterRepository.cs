using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IReviewChapterRepository : IGenericRepository<ReviewChapterEntity>
{
<<<<<<< HEAD
	Task<IList<ReviewChapterEntity>> GetChapterReviewsOfAChapterAsync(Guid chapterIdentifier);
	Task<IList<ReviewChapterEntity>> GetChapterReviewsOfAUserByUserId(Guid userId);
	Task DeleteReviewedOnChapter_OfAUser_ByUserIdAsync(Guid userId, Guid chapterId);
	Task<IList<ReviewChapterEntity>> GetAllChapterReviewAsync();
=======
    Task<IList<ReviewChapterEntity>> GetChapterReviewsOfAChapterAsync(Guid chapterIdentifier);
    Task<IList<ReviewChapterEntity>> GetChapterReviewsOfAUserByUserId(Guid userId);
    Task DeleteReviewedOnChapter_OfAUser_ByUserIdAsync(Guid userId, Guid chapterId);
    Task<IEnumerable<ReviewChapterEntity>> GetChapterReviewsWith_Username_UserAvatar_ChapterComment_ChapterRatingStars_ReviewTimeByChapterIdAsync(Guid chapterIdentifier);
>>>>>>> 547eb7a20fa5116c7ad141c4071552b871808977
}
