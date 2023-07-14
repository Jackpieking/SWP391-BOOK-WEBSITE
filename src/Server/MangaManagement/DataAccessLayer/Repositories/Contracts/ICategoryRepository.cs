using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface ICategoryRepository : IGenericRepository<CategoryEntity>
{
    Task UpdateCrawlDataAsync(IList<CategoryEntity> crawlCategoryEntities);
    Task<IList<Guid>> GetCategoryIdentifiersByCrawlCategoryNameAsync(IEnumerable<string> crawlCategoryNames);
    Task<CategoryEntity> GetCategoryByIdAsync(Guid id);
    Task<IEnumerable<CategoryEntity>> GetAllCategoryNoRelationAsync();
    Task<Guid> UpdateCategory(CategoryEntity category);
}
