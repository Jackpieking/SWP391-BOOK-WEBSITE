using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IComicRepository : IGenericRepository<ComicEntity>
{
    Task<IList<ComicEntity>> GetAllComicWith_ComicIdentifier_ComicPublishedDate_ComicName_ComicAvatarAsync();
    Task<ComicEntity> GetComicWith_ComicIdentifier_ComicName_ComicDescription_ComicAvatar_ComicPublishedDate_Username_ByComicIdentifierAsync(Guid comicIdentifier);
    Task<Guid> UpdateCrawlDataAsync(ComicEntity crawlComicEntity);
    Task<Guid> GetComicIdentifierByComicNameAsync(string comicName);
}
