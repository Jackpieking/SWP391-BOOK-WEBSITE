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
    public async Task<IEnumerable<ComicEntity>> GetAllComicNoRelationAsync() =>
        await _dbSet.ToListAsync();

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public async Task<IList<ComicEntity>> GetAllComicWith_ComicIdentifier_ComicPublishedDate_ComicName_ComicAvatarAsync()
    {
        return await _dbSet
            .Select(selector: comicEntity => new ComicEntity
            {
                ComicIdentifier = comicEntity.ComicIdentifier,
                ComicName = comicEntity.ComicName,
                ComicPublishedDate = comicEntity.ComicPublishedDate,
                ComicAvatar = comicEntity.ComicAvatar
            })
            .ToListAsync();
    }

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public async Task<ComicEntity> GetComicByIdAsync(Guid comicId)
    {
        var comic = await _dbSet.FirstOrDefaultAsync(comic => comic.ComicIdentifier == comicId);
        await _dbSet.Entry(comic).Collection(c => c.ChapterEntities).LoadAsync();
        await _dbSet.Entry(comic).Reference(c => c.PublisherEntity).LoadAsync();
        await _dbSet.Entry(comic).Collection(c => c.ReviewComicEntities).LoadAsync();
        var chapter = _dbSet.Select(comic => comic.ChapterEntities);
        return comic;
    }

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public async Task<ComicEntity> GetComicByIdNoRelationAsync(Guid comicId) =>
        await _dbSet.FirstOrDefaultAsync(comic => comic.ComicIdentifier == comicId);

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
    public async Task<ComicEntity> GetComicWith_ComicIdentifier_ComicName_ComicDescription_ComicAvatar_ComicPublishedDate_Username_ByComicIdentifierAsync(Guid comicIdentifier)
    {
        return await _dbSet
            .Where(predicate: comicEntity
                => comicEntity.ComicIdentifier == comicIdentifier)
            .Select(comicEntity => new ComicEntity
            {
                ComicName = comicEntity.ComicName,
                ComicDescription = comicEntity.ComicDescription,
                ComicAvatar = comicEntity.ComicAvatar,
                ComicPublishedDate = comicEntity.ComicPublishedDate,
                PublisherIdentifier = comicEntity.PublisherIdentifier
            })
            .FirstOrDefaultAsync();
    }

    public async Task<Guid> UpdateComicAsync(Guid comicId, string comicName, string comicDes, string comicPDate, string comicStatus)
    {
        var comicFound = await _dbSet
            .FirstOrDefaultAsync(comic => comic.ComicIdentifier == comicId);

        if (comicFound == null)
        {
            return Guid.Empty;
        }

        comicFound.ComicName = comicName;
        comicFound.ComicDescription = comicDes;
        comicFound.ComicPublishedDate = DateOnly.Parse(comicPDate);
        comicFound.ComicStatus = comicStatus;

        _dbSet.Update(entity: comicFound);

        return comicFound.ComicIdentifier;
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
