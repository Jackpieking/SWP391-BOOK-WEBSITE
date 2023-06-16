using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IComicRepository : IGenericRepository<ComicEntity>
{
	Task<IList<ComicEntity>> GetComicsFromDatabaseAsync();
	Task<ComicEntity> GetComicWithChapterListByComicIdentifierDatabaseAsync(Guid comicIdentifier);
	Task<Guid> UpdateCrawlDataAsync(ComicEntity crawlComicEntity);
	Task<Guid> GetComicIdentifierByComicNameAsync(string comicName);
}
