using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementation;

public class ChapterRepository : GenericRepository<ChapterEntity>, IChapterRepository
{
	public ChapterRepository(DbSet<ChapterEntity> dbSet) : base(dbSet: dbSet)
	{
	}

	public async Task<ChapterEntity> GetAChapterWithComicByChapterIdentifierFromDatabaseAsync(Guid chapterIdentifier)
	{
		return await _dbSet
			.Where(predicate: chapterEntity
				=> chapterEntity.ChapterIdentifier == chapterIdentifier)
			.Select(selector: chapterEntity => new ChapterEntity
			{
				ChapterIdentifier = chapterEntity.ChapterIdentifier,
				ChapterNumber = chapterEntity.ChapterNumber,
				ComicEntity = new()
				{
					ComicName = chapterEntity.ComicEntity.ComicName
				}
			})
			.FirstOrDefaultAsync();
	}

	public async Task<IEnumerable<ChapterEntity>> GetAllChaptersOfAComicFromDatabaseAsync(Guid comicIdentifier)
	{
		return await _dbSet
			.Where(predicate: chapterEntity
				=> chapterEntity.ComicIdentifier == comicIdentifier)
			.Select(chapterEntity => new ChapterEntity
			{
				ChapterIdentifier = chapterEntity.ChapterIdentifier,
				ChapterNumber = chapterEntity.ChapterNumber,
				ChapterUnlockPrice = chapterEntity.ChapterUnlockPrice,
				AddedDate = chapterEntity.AddedDate
			})
			.ToListAsync();
	}

	public async Task UpdateCrawlDataAsync(
		IEnumerable<ChapterEntity> crawlChapterEntities,
		string comicName)
	{
		foreach (var crawlChapterEntity in crawlChapterEntities)
		{
			var foundChapter = await _dbSet
				.FirstOrDefaultAsync(predicate: chapterEntity
					=> chapterEntity.ChapterNumber.Equals(crawlChapterEntity.ChapterNumber)
					&& chapterEntity.ComicEntity.ComicName.Equals(comicName));

			if (Equals(objA: foundChapter, objB: null))
			{
				await _dbSet.AddAsync(entity: crawlChapterEntity);
			}
		}
	}
}
