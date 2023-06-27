using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IReviewChapterRepository : IGenericRepository<ReviewChapterEntity>
{
<<<<<<< Updated upstream
	Task<IList<ReviewChapterEntity>> GetChapterReviewsOfAChapterAsync(Guid chapterIdentifier);
	Task<IList<ReviewChapterEntity>> GetChapterReviewsOfAUserByUserId(Guid userId);
=======
	Task<IEnumerable<ReviewChapterEntity>> GetAllChapterReviewsWith_Username_UserAvatar_ChapterComment_ChapterRatingStars_ReviewTimeByChapterIdentifierAsync(Guid chapterIdentifier);
>>>>>>> Stashed changes
}
