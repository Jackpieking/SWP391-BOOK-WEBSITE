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

    public async Task<IEnumerable<ComicCategoryEntity>> GetAllComicCategoriesByComicIdentifierFromDatabaseAsync(Guid comicIdentifier)
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
}
