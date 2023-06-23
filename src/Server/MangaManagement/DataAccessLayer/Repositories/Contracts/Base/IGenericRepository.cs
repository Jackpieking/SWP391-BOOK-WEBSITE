using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts.Base;

public interface IGenericRepository<T> where T : class
{
    Task AddAsync(T entity);
    Task AddRangeAsync(params T[] entities);
    Task AddRangeAsync(IEnumerable<T> entities);
    void Update(T entity);
    void UpdateRange(params T[] entities);
    void UpdateRange(IEnumerable<T> entities);
    void Delete(T entity);
    void DeleteRange(params T[] entities);
    void DeleteRange(IEnumerable<T> entities);
    Task<int> Count();
}
