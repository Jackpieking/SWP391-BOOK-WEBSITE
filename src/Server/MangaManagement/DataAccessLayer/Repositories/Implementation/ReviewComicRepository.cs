using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementation;

public class ReviewComicRepository : GenericRepository<ReviewComicEntity>, IReviewComicRepository
{
	public ReviewComicRepository(DbSet<ReviewComicEntity> dbSet) : base(dbSet: dbSet)
	{
	}

	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
	public async Task<IList<ReviewComicEntity>> GetReviewComicsWith_ComicId_ReviewTimeSortByComicId__Descending_ReviewTime__AscendingAsync()
	{
		return await _dbSet
			.Select(selector: reviewComic => new ReviewComicEntity
			{
				ComicIdentifier = reviewComic.ComicIdentifier,
				ReviewTime = reviewComic.ReviewTime
			})
			.OrderByDescending(keySelector: reviewComicModel => reviewComicModel.ComicIdentifier)
			.ThenByDescending(keySelector: reviewComicModel => reviewComicModel.ReviewTime)
			.ToListAsync();
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="comicIdentifier"></param>
	/// <returns></returns>
	public async Task<IList<ReviewComicEntity>> GetReviewComicsWith_ComicRatingStar_ComicComment_ReviewTime_Username_UserAvatarByComicIdAsync(Guid comicIdentifier)
	{
		return await _dbSet
			.Where(predicate: reviewComicEntity
				=> reviewComicEntity.ComicIdentifier == comicIdentifier)
			.Select(selector: reviewComicEntity => new ReviewComicEntity
			{
				ComicRatingStar = reviewComicEntity.ComicRatingStar,
				ComicComment = reviewComicEntity.ComicComment,
				ReviewTime = reviewComicEntity.ReviewTime,
				UserEntity = new()
				{
					Username = reviewComicEntity.UserEntity.Username,
					UserAvatar = reviewComicEntity.UserEntity.UserAvatar
				}
			})
			.ToListAsync();
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="userId"></param>
	/// <returns></returns>
	public async Task<IList<ReviewComicEntity>> GetComicReviewsByUserId(Guid userId)
	{
		return await _dbSet
			.Where(predicate: reviewComic => reviewComic.UserIdentifier.Equals(userId))
			.Select(reviewComic => new ReviewComicEntity
			{
				ComicEntity = new ComicEntity()
				{
					ComicName = reviewComic.ComicEntity.ComicName
				},
				ComicComment = reviewComic.ComicComment,
				ComicRatingStar = reviewComic.ComicRatingStar,
				ReviewTime = reviewComic.ReviewTime
			})
			.ToListAsync();
	}

	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
	public async Task<IDictionary<Guid, int>> GetReviewComicCountOfComicsAsync()
	{
		var queryResult = from reviewComicEntity in _dbSet
						  group reviewComicEntity by reviewComicEntity.ComicIdentifier
						  into result
						  select new
						  {
							  ComicIdentifier = result.Key,
							  ComicIdentiferCount = result.Count()
						  };

		return await queryResult.ToDictionaryAsync(
			keySelector: res => res.ComicIdentifier,
			elementSelector: res => res.ComicIdentiferCount);
	}

	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
	public async Task<IDictionary<Guid, DateTime>> GetLastestComicReviewDateOfComicsAsync()
	{
		IDictionary<Guid, DateTime> latestReviewComics = new Dictionary<Guid, DateTime>();

		await _dbSet
			.Select(reviewComicEntity => new ReviewComicEntity
			{
				ComicIdentifier = reviewComicEntity.ComicIdentifier,
				ReviewTime = reviewComicEntity.ReviewTime
			})
			.OrderByDescending(keySelector: reviewComicEntity => reviewComicEntity.ComicIdentifier)
			.OrderByDescending(keySelector: reviewComicEntity => reviewComicEntity.ReviewTime)
			.ForEachAsync(reviewComicEntity =>
			{
				latestReviewComics.TryAdd(
					key: reviewComicEntity.ComicIdentifier,
					value: reviewComicEntity.ReviewTime);
			});

		return latestReviewComics;
	}
}
