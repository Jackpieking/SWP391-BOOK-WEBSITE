using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Contracts.Base;

public interface IGenericRepository<T> where T : class
{
    Task AddAsync(T item);
    Task AddRangeAsync(params T[] items);
    void Update(T item);
    void UpdateRange(params T[] items);
    void Delete(T item);
    void DeleteRange(params T[] items);
}
