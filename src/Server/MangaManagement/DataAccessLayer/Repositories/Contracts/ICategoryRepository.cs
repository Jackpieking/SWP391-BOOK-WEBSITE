using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface ICategoryRepository : IGenericRepository<CategoryEntity>
{
    public Task<CategoryEntity> GetCategoryByIdAsync(Guid id);
    Task<IEnumerable<CategoryEntity>> GetAllCategoryNoRelationAsync();
    Task UpdateCrawlDataAsync(IList<CategoryEntity> crawlCategoryEntities);
    Task<IList<Guid>> GetCategoryIdentifiersByCrawlCategoryNameAsync(IEnumerable<string> crawlCategoryNames);
    Task<IEnumerable<CategoryEntity>> GetAllCategoryByComicId(Guid comicId);
    Task<Guid> UpdateCategoryAsync(Guid catId, string catName, string catDescription);
}
