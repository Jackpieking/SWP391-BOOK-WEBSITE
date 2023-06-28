using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IReviewComicRepository : IGenericRepository<ReviewComicEntity>
{
	Task<IList<ReviewComicEntity>> GetReviewComicsWith_ComicId_ReviewTimeSortByComicId__Descending_ReviewTime__AscendingAsync();
	Task<IList<ReviewComicEntity>> GetReviewComicsWith_ComicRatingStar_ComicComment_ReviewTime_Username_UserAvatarByComicIdAsync(Guid comicIdentifier);
	Task<IList<ReviewComicEntity>> GetComicReviewsByUserId(Guid userId);
	Task<IDictionary<Guid, int>> GetReviewComicCountOfComicsAsync();
	Task<IDictionary<Guid, DateTime>> GetLastestComicReviewDateOfComicsAsync();
}
