using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementation;

public class ComicRepository : GenericRepository<ComicEntity>, IComicRepository
{
	public ComicRepository(DbSet<ComicEntity> dbSet) : base(dbSet: dbSet)
	{
	}

	public async Task<IEnumerable<ComicEntity>> GetAllComicsFromDatabaseAsync()
	{
		return await _dbSet
			.Select(selector: comicEntity => new ComicEntity
			{
				ComicIdentifier = comicEntity.ComicIdentifier,
				ComicPublishedDate = comicEntity.ComicPublishedDate,
				ComicName = comicEntity.ComicName,
				//ComicLatestChapter = comicEntity.ComicLatestChapter,
				ComicAvatar = comicEntity.ComicAvatar
			})
			.ToListAsync();
	}

	public async Task<Guid> GetComicIdentifierByComicNameAsync(string comicName)
	{
		var comicEntity = await _dbSet
			.FirstOrDefaultAsync(comicEntity => comicEntity.ComicName.Equals(comicName));

		return comicEntity.ComicIdentifier;
	}

	public async Task<ComicEntity> GetComicWithChapterListByComicIdentifierDatabaseAsync(Guid comicIdentifier)
	{
		return await _dbSet
			.Where(predicate: comicEntity
				=> comicEntity.ComicIdentifier == comicIdentifier)
			.Select(comicEntity => new ComicEntity
			{
				ComicIdentifier = comicIdentifier,
				ComicName = comicEntity.ComicName,
				ComicDescription = comicEntity.ComicDescription,
				ComicAvatar = comicEntity.ComicAvatar,
				ComicPublishedDate = comicEntity.ComicPublishedDate,
				//ComicLatestChapter = comicEntity.ComicLatestChapter,
				PublisherEntity = new()
				{
					PublisherIdentifier = comicEntity.PublisherIdentifier,
					UserEntity = new()
					{
						Username = comicEntity
							.PublisherEntity
							.UserEntity
							.Username
					}
				}
			})
			.FirstOrDefaultAsync();
	}

	public async Task UpdateCrawlDataAsync(ComicEntity crawlComicEntity)
	{
		var comicEntityIsFound = await _dbSet
			.FirstOrDefaultAsync(predicate: comicEntity
				=> comicEntity.ComicName == crawlComicEntity.ComicName);

		if (Equals(objA: comicEntityIsFound, objB: null))
		{
			await _dbSet.AddAsync(entity: crawlComicEntity);

			return;
		}

		if (!comicEntityIsFound.ComicDescription.Equals(
			value: crawlComicEntity.ComicDescription,
			comparisonType: StringComparison.Ordinal))
		{
			comicEntityIsFound.ComicDescription = crawlComicEntity.ComicDescription;
		}

		if (!comicEntityIsFound.ComicPublishedDate.Equals(
			value: crawlComicEntity.ComicPublishedDate))
		{
			comicEntityIsFound.ComicPublishedDate = crawlComicEntity.ComicPublishedDate;
		}

		if (!comicEntityIsFound.ComicStatus.Equals(
			value: crawlComicEntity.ComicStatus,
			comparisonType: StringComparison.Ordinal))
		{
			comicEntityIsFound.ComicStatus = crawlComicEntity.ComicStatus;
		}

		_dbSet.Update(entity: comicEntityIsFound);
	}
}
