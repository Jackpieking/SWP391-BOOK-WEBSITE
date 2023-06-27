using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IReviewChapterRepository : IGenericRepository<ReviewChapterEntity>
{
	Task<IList<ReviewChapterEntity>> GetChapterReviewsOfAChapterAsync(Guid chapterIdentifier);
	Task<IList<ReviewChapterEntity>> GetChapterReviewsOfAUserByUserId(Guid userId);
}
