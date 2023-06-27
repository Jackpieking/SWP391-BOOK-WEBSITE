using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IComicRepository : IGenericRepository<ComicEntity>
{
<<<<<<< Updated upstream
<<<<<<< HEAD
=======
    Task<IList<ComicEntity>> GetAllComicAsync();
>>>>>>> c86f98a6ee0d041c58490069b911605912b072b6
    Task<IList<ComicEntity>> GetAllComicWith_ComicIdentifier_ComicPublishedDate_ComicName_ComicAvatarAsync();
    Task<ComicEntity> GetComicWith_ComicIdentifier_ComicName_ComicDescription_ComicAvatar_ComicPublishedDate_Username_ByComicIdentifierAsync(Guid comicIdentifier);
    Task<Guid> UpdateCrawlDataAsync(ComicEntity crawlComicEntity);
    Task<Guid> GetComicIdentifierByComicNameAsync(string comicName);
=======
	Task<IList<ComicEntity>> GetAllComicsWith_ComicIdentifier_ComicPublishedDate_ComicName_ComicAvatarAsync();
	Task<ComicEntity> GetComicWith_ComicIdentifier_ComicName_ComicDescription_ComicAvatar_ComicPublishedDate_PunlisherIdentifier_ByComicIdentifierAsync(Guid comicIdentifier);
	Task<Guid> UpdateCrawlDataAsync(ComicEntity crawlComicEntity);
	Task<Guid> GetComicIdentifierByComicNameAsync(string comicName);
>>>>>>> Stashed changes
}
