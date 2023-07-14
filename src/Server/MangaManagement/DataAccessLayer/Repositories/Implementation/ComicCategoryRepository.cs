using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementation;

public class ComicCategoryRepository : GenericRepository<ComicCategoryEntity>, IComicCategoryRepository
{
    public ComicCategoryRepository(DbSet<ComicCategoryEntity> dbSet) : base(dbSet: dbSet)
    {
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="comicIdentifier"></param>
    /// <returns></returns>
    public async Task<IList<ComicCategoryEntity>> GetComicCategoryNamesByComicIdentifierFromDatabaseAsync(Guid comicIdentifier)
    {
        var foundComicCategories = _dbSet
            .Where(predicate: comicCategoryEntity
                => comicCategoryEntity.ComicIdentifier == comicIdentifier);

        if (await foundComicCategories.AnyAsync() == default)
        {
            return new List<ComicCategoryEntity>();
        }

        return await foundComicCategories
            .Select(selector: comicCategoryEntity => new ComicCategoryEntity
            {
                CategoryIdentifier = comicCategoryEntity.CategoryIdentifier
            })
            .ToListAsync();
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="comicIdentifier"></param>
    /// <returns></returns>
    public async Task<IList<ComicCategoryEntity>> GetComicCategoryNameByComicIdentifierFromDatabaseAsync(Guid comicIdentifier)
    {
        return await _dbSet
            .Where(predicate: comicCategoryEntity
                => comicCategoryEntity.ComicIdentifier == comicIdentifier)
            .Select(selector: comicCategoryEntity => new ComicCategoryEntity
            {
                CategoryEntity = new()
                {
                    CategoryName = comicCategoryEntity.CategoryEntity.CategoryName
                }
            })
            .ToListAsync();
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="comicIdentifier"></param>
    /// <param name="categoryidentifiers"></param>
    /// <returns></returns>
    public async Task UpdateCrawlDataAsync(
        Guid comicIdentifier,
        IList<Guid> categoryidentifiers)
    {
        foreach (var categoryIdentifier in categoryidentifiers)
        {
            ComicCategoryEntity comicCategoryEntity = new()
            {
                CategoryIdentifier = categoryIdentifier,
                ComicIdentifier = comicIdentifier
            };

            await _dbSet.AddAsync(entity: comicCategoryEntity);
        }
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="comicIdentifier"></param>
    public void DeleteComicCategoriesByComicIdentifier(Guid comicIdentifier)
    {
        //find comic category base on comic identifier
        var foundComicCategoryEntities = _dbSet
            .Where(predicate: comicCategoryEntity
                => comicCategoryEntity.ComicIdentifier == comicIdentifier);

        //comic categories matching comic identifier were found
        {
            _dbSet.RemoveRange(entities: foundComicCategoryEntities);
        }
    }

    /// <summary>
    ///
    /// </summary>
    /// <param></param>
    public async Task<IEnumerable<ComicCategoryEntity>> GetAllComicCategoryNoRelationAsync() =>
        await _dbSet.ToListAsync();
}
