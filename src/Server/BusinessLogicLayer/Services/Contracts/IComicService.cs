using Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Contracts;

public interface IComicService
{
    Task<IEnumerable<ComicModel>> GetAllComicFromDatabaseAsync();
}
