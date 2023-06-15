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

	public async Task<IList<ComicCategoryEntity>> GetAllComicCategoryNameByComicIdentifierFromDatabaseAsync(Guid comicIdentifier)
	{
		var foundComicCategories = _dbSet
			.Where(predicate: comicCategoryEntity
				=> comicCategoryEntity.ComicIdentifier == comicIdentifier);

		if (Equals(objA: foundComicCategories, objB: null))
		{
			return new List<ComicCategoryEntity>();
		}

		return await foundComicCategories
			.Select(selector: comicCategoryEntity => new ComicCategoryEntity
			{
				CategoryIdentifier = comicCategoryEntity.ComicIdentifier,
				CategoryEntity = new()
				{
					CategoryName = comicCategoryEntity.CategoryEntity.CategoryName
				}
			})
			.ToListAsync();
	}

	public async Task<IEnumerable<ComicCategoryEntity>> GetComicCategoryNameByComicIdentifierFromDatabaseAsync(Guid comicIdentifier)
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

	public async Task UpdateCrawlDataAsync(
		Guid comicIdentifier,
		IEnumerable<Guid> categoryidentifiers)
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
}
