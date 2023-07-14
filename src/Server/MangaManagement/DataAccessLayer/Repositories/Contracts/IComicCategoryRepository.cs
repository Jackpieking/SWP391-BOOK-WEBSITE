using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IComicCategoryRepository : IGenericRepository<ComicCategoryEntity>
{
    Task<IList<ComicCategoryEntity>> GetComicCategoryNameByComicIdentifierFromDatabaseAsync(Guid comicIdentifier);
    void DeleteComicCategoriesByComicIdentifier(Guid comicIdentifier);
    Task UpdateCrawlDataAsync(Guid comicIdentifier, IList<Guid> categoryidentifiers);
    Task<IEnumerable<ComicCategoryEntity>> GetAllComicCategoryNoRelationAsync();
}
