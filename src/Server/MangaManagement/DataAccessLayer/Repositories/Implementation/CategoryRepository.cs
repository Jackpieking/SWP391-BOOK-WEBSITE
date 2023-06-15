using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementation;

public class CategoryRepository : GenericRepository<CategoryEntity>, ICategoryRepository
{
	public CategoryRepository(DbSet<CategoryEntity> dbSet) : base(dbSet: dbSet)
	{
	}

	public async Task<IEnumerable<Guid>> GetCategoryIdentifierByCategoryNameAsync(IEnumerable<string> categoryNames)
	{
		IList<Guid> categoryEntities = new List<Guid>();

		foreach (var categoryName in categoryNames)
		{
			var categoryEntity = await _dbSet
				.FirstOrDefaultAsync(categoryModel
					=> categoryModel.CategoryName.Equals(categoryName));

			categoryEntities.Add(item: categoryEntity.CategoryIdentifier);
		}

		return categoryEntities;
	}

	public async Task UpdateCrawlDataAsync(IEnumerable<CategoryEntity> crawlCategoryEntities)
	{
		foreach (var crawlCategoryEntity in crawlCategoryEntities)
		{
			var foundCategory = await _dbSet
				.FirstOrDefaultAsync(predicate: categoryEntity
					=> categoryEntity.CategoryName.Equals(crawlCategoryEntity.CategoryName));

			if (Equals(objA: foundCategory, objB: null))
			{
				await _dbSet.AddAsync(entity: crawlCategoryEntity);
			}
		}
	}
}
