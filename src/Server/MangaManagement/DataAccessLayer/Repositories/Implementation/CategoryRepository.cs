using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementation;

public class CategoryRepository : GenericRepository<CategoryEntity>, ICategoryRepository
{
    public CategoryRepository(DbSet<CategoryEntity> dbSet) : base(dbSet: dbSet)
    {
    }

    /// <summary>
    ///
    /// </summary>
    /// <param></param>
    /// <returns></returns>
    public async Task<IEnumerable<CategoryEntity>> GetAllCategoryNoRelationAsync() => await _dbSet.ToListAsync();

    /// <summary>
    /// Get category entity by Id
    /// </summary>
    /// <returns>Task<CategoryEntity></returns>
    public async Task<CategoryEntity> GetCategoryByIdAsync(Guid catId) =>
        await _dbSet.FirstOrDefaultAsync(cat => cat.CategoryIdentifier == catId);

    /// <summary>
    ///
    /// </summary>
    /// <param name="crawlCategoryNames"></param>
    /// <returns></returns>
    public async Task<IList<Guid>> GetCategoryIdentifiersByCrawlCategoryNameAsync(IEnumerable<string> crawlCategoryNames)
    {
        IList<Guid> categoryIdentifiers = new List<Guid>();

        foreach (var crawlCategoryName in crawlCategoryNames)
        {
            //find category identifier base on category name
            var foundCategoryEntity = await _dbSet
                .Where(predicate: categoryEntity
                    => categoryEntity.CategoryName.Equals(crawlCategoryName))
                .Select(selector: categoryEntity => new CategoryEntity
                {
                    CategoryIdentifier = categoryEntity.CategoryIdentifier
                })
                .FirstOrDefaultAsync();

            //add to category name containers
            categoryIdentifiers.Add(item: foundCategoryEntity.CategoryIdentifier);
        }

        return categoryIdentifiers;
    }

    public Task<Guid> UpdateCategory(CategoryEntity category)
    {
        _dbSet.Update(entity: category);
        return Task.FromResult(category.CategoryIdentifier);
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="crawlCategoryEntities"></param>
    /// <returns></returns>
    public async Task UpdateCrawlDataAsync(IList<CategoryEntity> crawlCategoryEntities)
    {
        foreach (var crawlCategoryEntity in crawlCategoryEntities)
        {
            //find existing category by category name
            var foundCategory = await _dbSet
                .Where(predicate: categoryEntity
                    => categoryEntity.CategoryName
                        .Equals(crawlCategoryEntity.CategoryName))
                .Select(selector: categoryEntity => new CategoryEntity
                {
                    CategoryIdentifier = crawlCategoryEntity.CategoryIdentifier
                })
                .FirstOrDefaultAsync();

            //if category is not exist
            if (Equals(objA: foundCategory, objB: null))
            {
                await _dbSet.AddAsync(entity: crawlCategoryEntity);
            }
        }
    }
}
