using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repositories.Implementation;

public class ReviewComicRepository : GenericRepository<ReviewComicEntity>, IReviewComicRepository
{
    public ReviewComicRepository(DbSet<ReviewComicEntity> dbSet) : base(dbSet: dbSet)
    {
    }

    /// <summary>
    /// Select from "ReviewComic" table these fields:
    /// - ComicIdentifier
    /// - ReviewTime
    /// </summary>
    /// <returns>IEnumerable<ReviewComicEntity></returns>
    public IEnumerable<ReviewComicEntity> GetReviewComicFromDatabase()
    {
        return _dbSet
            .Select(selector: reviewComic => new ReviewComicEntity
            {
                ComicIdentifier = reviewComic.ComicIdentifier,
                ReviewTime = reviewComic.ReviewTime
            })
            .AsEnumerable();
    }
}
