using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IComicCategoryRepository : IGenericRepository<ComicCategoryEntity>
{
	Task<IList<ComicCategoryEntity>> GetComicCategoryNamesByComicIdAsync(Guid comicIdentifier);
	void DeleteComicCategoriesByComicId(Guid comicIdentifier);
	Task UpdateCrawlDataAsync(Guid comicIdentifier, IList<Guid> categoryidentifiers);
}
