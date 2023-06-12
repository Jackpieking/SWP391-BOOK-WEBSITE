using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IChapterImageRepository : IGenericRepository<ChapterImageEntity>
{
    Task<IEnumerable<ChapterImageEntity>> GetAllChapterImageOfAChapterFromDatabaseAsync(Guid chapterIdentifier);
}
