using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IReviewComicRepository : IGenericRepository<ReviewComicEntity>
{
    Task<IEnumerable<ReviewComicEntity>> GetAllReviewComicFromDatabaseAsync();
    Task<IEnumerable<ReviewComicEntity>> GetAllReviewComicByComicIdentifierFromDatabaseAsync(Guid comicIdentifier);
}
