using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repositories.Implementation;

public class ComicCategoryRepository : GenericRepository<ComicCategoryEntity>, IComicCategoryRepository
{
    public ComicCategoryRepository(DbSet<ComicCategoryEntity> dbSet) : base(dbSet: dbSet)
    {
    }

    /// <summary>
    /// Select from "ComicCategory" table these field
    /// - category name from category reference
    /// Requirement: equal to given comicIdentifier
    /// </summary>
    /// <param name="comicIdentifier"></param>
    /// <returns></returns>
    public IEnumerable<ComicCategoryEntity> GetAllComicCategoryByComicIdentifierFromDatabase(Guid comicIdentifier)
    {
        return _dbSet
            .Where(predicate: comicCategoryEntity
                => comicCategoryEntity.ComicIdentifier == comicIdentifier)
            .Select(selector: comicCategoryEntity => new ComicCategoryEntity
            {
                CategoryEntity = new()
                {
                    CategoryName = comicCategoryEntity.CategoryEntity.CategoryName
                }
            });
    }
}
