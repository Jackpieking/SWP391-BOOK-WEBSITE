using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System.Collections.Generic;

namespace DataAccessLayer.Repositories.Contracts;

public interface IComicRepository : IGenericRepository<ComicEntity>
{
    IEnumerable<ComicEntity> GetAllComicFromDatabase();
}
