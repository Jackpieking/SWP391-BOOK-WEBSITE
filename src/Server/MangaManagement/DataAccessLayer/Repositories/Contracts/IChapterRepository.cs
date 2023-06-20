using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IChapterRepository : IGenericRepository<ChapterEntity>
{
    Task<IList<ChapterEntity>> GetChapterWith_ChapterIdentifier_ChapterNumber_ChapterUnlockPrice_ChapterAddedDateAsync(Guid comicIdentifier);
    Task<ChapterEntity> GetChapterWithComicByChapterIdentifierFromDatabaseAsync(Guid chapterIdentifier);
    Task UpdateCrawlDataAsync(IList<ChapterEntity> crawlChapterEntities, Guid comicIdentifier);
    Task<IEnumerable<ChapterEntity>> GetAllChapterWith_ChapterNumber_ComicIdentitiferAsync();
}
