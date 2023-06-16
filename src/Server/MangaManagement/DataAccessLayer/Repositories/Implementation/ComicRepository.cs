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

	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
	public async Task<IList<ComicEntity>> GetComicsFromDatabaseAsync()
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

	/// <summary>
	///
	/// </summary>
	/// <param name="comicName"></param>
	/// <returns></returns>
	public async Task<Guid> GetComicIdentifierByComicNameAsync(string comicName)
	{
		var comicEntity = await _dbSet
			.Where(predicate: comicEntity
				=> comicEntity.ComicName.Equals(comicName))
			.Select(comicEntity => new ComicEntity
			{
				ComicIdentifier = comicEntity.ComicIdentifier
			})
			.FirstOrDefaultAsync();

		return comicEntity.ComicIdentifier;
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="comicIdentifier"></param>
	/// <returns></returns>
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

	/// <summary>
	///
	/// </summary>
	/// <param name="crawlComicEntity"></param>
	/// <returns></returns>
	public async Task<Guid> UpdateCrawlDataAsync(ComicEntity crawlComicEntity)
	{
		//find the existing comic by comic name
		var comicEntityIsFound = await _dbSet
			.FirstOrDefaultAsync(predicate: comicEntity
				=> comicEntity.ComicName == crawlComicEntity.ComicName);

		//comic is not exist
		if (Equals(objA: comicEntityIsFound, objB: null))
		{
			await _dbSet.AddAsync(entity: crawlComicEntity);

			return crawlComicEntity.ComicIdentifier;
		}

		//update comic descripttion
		if (!comicEntityIsFound.ComicDescription.Equals(
			value: crawlComicEntity.ComicDescription))
		{
			comicEntityIsFound.ComicDescription = crawlComicEntity.ComicDescription;
		}

		//update comic published date
		if (!comicEntityIsFound.ComicPublishedDate.Equals(
			value: crawlComicEntity.ComicPublishedDate))
		{
			comicEntityIsFound.ComicPublishedDate = crawlComicEntity.ComicPublishedDate;
		}

		//update comic status
		if (!comicEntityIsFound.ComicStatus.Equals(
			value: crawlComicEntity.ComicStatus))
		{
			comicEntityIsFound.ComicStatus = crawlComicEntity.ComicStatus;
		}

		_dbSet.Update(entity: comicEntityIsFound);

		return comicEntityIsFound.ComicIdentifier;
	}
}
