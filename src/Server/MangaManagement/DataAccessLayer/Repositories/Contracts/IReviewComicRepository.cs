using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IReviewComicRepository : IGenericRepository<ReviewComicEntity>
{
	Task<IList<ReviewComicEntity>> GetReviewComicsFromDatabaseAsync();
	Task<IList<ReviewComicEntity>> GetReviewComicsByComicIdentifierFromDatabaseAsync(Guid comicIdentifier);
}
