using DataAccessLayer.Repositories.Contracts.Base;
using Entity;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Repositories.Contracts;

public interface IComicCategoryRepository : IGenericRepository<ComicCategoryEntity>
{
    IEnumerable<ComicCategoryEntity> GetAllComicCategoryByComicIdentifierFromDatabase(Guid comicIdentifier);
}
