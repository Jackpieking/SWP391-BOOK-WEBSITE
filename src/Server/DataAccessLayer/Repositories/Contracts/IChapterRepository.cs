using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IChapterRepository : IGenericRepository<ChapterEntity>
{
    Task<IEnumerable<ChapterEntity>> GetAllChapterOfAComicAsync(Guid comicIdentifier);
}
