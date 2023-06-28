using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IChapterRepository : IGenericRepository<ChapterEntity>
{
	Task<IEnumerable<ChapterEntity>> GetChaptersWith_ChapterId_ChapterNumber_ChapterUnlockPrice_ChapterAddedDateByComicIdAsync(Guid comicIdentifier);
	Task<ChapterEntity> GetChapterWith_ComicIdByChapterIdAsync(Guid chapterIdentifier);
	Task UpdateCrawlDataAsync(IList<ChapterEntity> crawlChapterEntities, Guid comicIdentifier);
	Task<IEnumerable<ChapterEntity>> GetChapterWith_ChapterNumber_ComicIdAsync();
	Task<IDictionary<Guid, string>> GetTheLastestChapterNumberOfComicsAsync();
	Task<IList<ChapterEntity>> GetChaptersWith_ChapterId_ChapterNumberByComicNameAsync(string comicName);
}
