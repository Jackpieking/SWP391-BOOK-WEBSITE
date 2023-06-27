﻿using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IReviewComicRepository : IGenericRepository<ReviewComicEntity>
{
<<<<<<< Updated upstream
    Task<IList<ReviewComicEntity>> GetAllReviewComicsWith_ComicIdentifier_ReviewTimeAsync();
    Task<IList<ReviewComicEntity>> GetAllReviewComicsWith_ComicRatingStar_ComicComment_ReviewTime_Username_UserAvatarByComicIdentifierAsync(Guid comicIdentifier);
<<<<<<< HEAD
=======
    Task<IList<ReviewComicEntity>> GetComicReviewsOfAUserByUserId(Guid userId);
>>>>>>> c86f98a6ee0d041c58490069b911605912b072b6
=======
	Task<IList<ReviewComicEntity>> GetAllReviewComicsWith_ComicIdentifier_ReviewTimeAsync();
	Task<IList<ReviewComicEntity>> GetAllReviewComicsWith_ComicRatingStar_ComicComment_ReviewTime_Username_UserAvatarByComicIdentifierAsync(Guid comicIdentifier);
	Task<IDictionary<Guid, int>> GetReviewComicCountOfAllComicsAsync();
	Task<IDictionary<Guid, DateTime>> GetLastestComicReviewDateOfAllComicsAsync();
>>>>>>> Stashed changes
}
