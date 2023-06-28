using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IComicRepository : IGenericRepository<ComicEntity>
{
	Task<IList<ComicEntity>> GetComicsAsync();
	Task<IList<ComicEntity>> GetComicsWith_ComicId_ComicName_ComicPublishedDate_ComicAvatarAsync();
	Task<ComicEntity> GetComicWith_ComicName_ComicDescription_ComicAvatar_ComicPublishedDate_PublisherId_ByComicIdAsync(Guid comicIdentifier);
	Task<Guid> UpdateCrawlDataAsync(ComicEntity crawlComicEntity);
	Task<Guid> GetComicIdByComicNameAsync(string comicName);
	Task<ComicEntity> GetComicWith_ComicId_ComicName_ComicDescription_ComicAvatar_ComicPublishedDate_PublisherId_ByComicIdAsync(Guid comicIdentifier);
}
