using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation.Base;
using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Implementation;

public class ReadingHistoryRepository : GenericRepository<ReadingHistory>, IReadingHistoryRepository
{
	public ReadingHistoryRepository(DbSet<ReadingHistory> dbSet) : base(dbSet)
	{
	}
}
