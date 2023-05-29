using MangaManagementAPI.Data.ModelConfiguations;
using MangaManagementAPI.Data.ModelDataSeedings;
using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MangaManagementAPI.Data;

public class MangaContext : DbContext
{
	public DbSet<LoginAccount> LoginAccount { get; set; }

	public DbSet<UserAccess> UserAccess { get; set; }

	public DbSet<TransactionsHistory> TransactionsHistories {get; set;}

	public MangaContext(DbContextOptions options) : base(options) { }



	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		//table configuration
		modelBuilder
			.ApplyConfiguration(new LoginAccountConfiguration())
			.ApplyConfiguration(new UserAccessConfiguration());

		//Data seeding
		modelBuilder
			.ApplyConfiguration(new LoginAccountDataSeeding())
			.ApplyConfiguration(new UserAccessDataSeeding());
	}
}
