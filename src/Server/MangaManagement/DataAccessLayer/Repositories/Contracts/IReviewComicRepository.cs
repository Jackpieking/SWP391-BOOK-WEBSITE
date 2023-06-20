using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IReviewComicRepository : IGenericRepository<ReviewComicEntity>
{
    Task<IList<ReviewComicEntity>> GetAllReviewComicsWith_ComicIdentifier_ReviewTimeAsync();
    Task<IList<ReviewComicEntity>> GetAllReviewComicsWith_ComicRatingStar_ComicComment_ReviewTime_Username_UserAvatarByComicIdentifierAsync(Guid comicIdentifier);
}
