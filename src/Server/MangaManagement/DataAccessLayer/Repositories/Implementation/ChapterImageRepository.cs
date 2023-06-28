using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementation;

public class ChapterImageRepository : GenericRepository<ChapterImageEntity>, IChapterImageRepository
{
	public ChapterImageRepository(DbSet<ChapterImageEntity> dbSet) : base(dbSet: dbSet)
	{
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="chapterIdentifier"></param>
	/// <returns></returns>
	public async Task<IEnumerable<ChapterImageEntity>> GetChapterImagesWith_ImageUrlByChapterIdAsync(Guid chapterIdentifier)
	{
		return await _dbSet
			.Where(predicate: predicate
				=> predicate.ChapterIdentifier == chapterIdentifier)
			.OrderBy(keySelector: chapterImage => chapterImage.ImageNumber)
			.Select(selector: chapterImage => new ChapterImageEntity
			{
				ImageURL = chapterImage.ImageURL,
			})
			.ToListAsync();
	}
}
