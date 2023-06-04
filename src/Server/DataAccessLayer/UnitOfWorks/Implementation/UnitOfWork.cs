using DataAccessLayer.UnitOfWorks.Contracts;
using MangaManagementAPI.Data;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWorks.Implementation;

public class UnitOfWork : IUnitOfWork
{
	private readonly MangaContext _context;

	public UnitOfWork(MangaContext context) => _context = context;

	public async Task SaveAsync(CancellationToken cancellationToken)
		=> await _context.SaveChangesAsync(cancellationToken: cancellationToken);
}
