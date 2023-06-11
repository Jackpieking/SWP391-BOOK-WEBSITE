using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Repositories.Contracts;

public interface IReviewComicRepository : IGenericRepository<ReviewComicEntity>
{
    IEnumerable<ReviewComicEntity> GetAllReviewComicFromDatabase();
    IEnumerable<ReviewComicEntity> GetAllReviewComicByComicIdentifierFromDatabase(Guid comicIdentifier);
}
