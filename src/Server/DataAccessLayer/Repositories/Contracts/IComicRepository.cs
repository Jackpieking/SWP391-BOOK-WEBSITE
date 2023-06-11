using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IComicRepository : IGenericRepository<ComicEntity>
{
    IEnumerable<ComicEntity> GetAllComicFromDatabase();
    Task<ComicEntity> GetComicByComicIdentifierDatabaseAsync(Guid comicIdentifier);
}
