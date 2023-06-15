using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface ICategoryRepository : IGenericRepository<CategoryEntity>
{
	Task UpdateCrawlDataAsync(IEnumerable<CategoryEntity> crawlCategoryEntities);
	Task<IEnumerable<Guid>> GetCategoryIdentifierByCategoryNameAsync(IEnumerable<string> crawlCategoryName);
}
