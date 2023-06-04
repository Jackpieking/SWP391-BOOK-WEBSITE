using System.Threading;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWorks.Contracts;

public interface IUnitOfWork
{
	Task SaveAsync(CancellationToken cancellationToken);
}
