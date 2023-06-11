using DataAccessLayer.Repositories.Contracts.Base;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementation.Base;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly DbSet<T> _dbSet;

    protected GenericRepository(DbSet<T> dbSet) => _dbSet = dbSet;

    public async Task AddAsync(T item)
        => await _dbSet.AddAsync(entity: item);

    public async Task AddRangeAsync(params T[] items)
        => await _dbSet.AddRangeAsync(entities: items);

    public void Delete(T item)
        => _dbSet.Remove(entity: item);

    public void DeleteRange(params T[] items)
        => _dbSet.RemoveRange(entities: items);

    public void Update(T item)
        => _dbSet.Update(entity: item);

    public void UpdateRange(params T[] items)
        => _dbSet.UpdateRange(entities: items);
}
