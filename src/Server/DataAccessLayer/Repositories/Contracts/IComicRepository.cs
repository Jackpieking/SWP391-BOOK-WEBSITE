using DataAccessLayer.Repositories.Contracts.Base;
using DataAccessLayer.Data.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IComicRepository : IGenericRepository<ComicEntity>
{
    Task<IEnumerable<ComicEntity>> GetAllComicAsync();
}
