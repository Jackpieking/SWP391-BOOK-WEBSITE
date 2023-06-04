using DataAccessLayer.Repositories.Contracts.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

	public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
		=> _dbSet.Where(predicate: predicate).AsEnumerable();

	public void Update(T item)
		=> _dbSet.Update(entity: item);

	public void UpdateRange(params T[] items)
		=> _dbSet.UpdateRange(entities: items);
}
