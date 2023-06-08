using DataAccessLayer.Repositories.Contracts.Base;
using MangaManagementAPI.Data.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts;

public interface IComicRepository : IGenericRepository<Comic>
{
    Task<IEnumerable<Comic>> GetAllComicAsync();
}
