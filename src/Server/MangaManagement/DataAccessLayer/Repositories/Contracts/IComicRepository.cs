using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IComicRepository : IGenericRepository<ComicEntity>
{
	Task<IEnumerable<ComicEntity>> GetAllComicsFromDatabaseAsync();
	Task<ComicEntity> GetComicWithChapterListByComicIdentifierDatabaseAsync(Guid comicIdentifier);
	Task UpdateCrawlDataAsync(ComicEntity crawlComicEntity);
	Task<Guid> GetComicIdentifierByComicNameAsync(string comicName);
}
