using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IReviewChapterRepository : IGenericRepository<ReviewChapterEntity>
{
    Task<IList<ReviewChapterEntity>> GetChapterReviewsOfAChapterAsync(Guid chapterIdentifier);
    Task<IEnumerable<ReviewChapterEntity>> GetChapterReviewsOfAUserByUserId(Guid userId);
    Task DeleteReviewedOnChapter_OfAUser_ByUserIdAsync(Guid userId, Guid chapterId);
    Task<IList<ReviewChapterEntity>> GetAllChapterReviewAsync();
    Task<IEnumerable<ReviewChapterEntity>> GetChapterReviewsWith_Username_UserAvatar_ChapterComment_ChapterRatingStars_ReviewTimeByChapterIdAsync(Guid chapterIdentifier);
}
