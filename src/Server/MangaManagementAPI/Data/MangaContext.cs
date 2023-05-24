using MangaManagementAPI.Data.ModelConfiguations;
using MangaManagementAPI.Data.ModelDataSeedings;
using Microsoft.EntityFrameworkCore;

namespace MangaManagementAPI.Data;

public class MangaContext : DbContext
{
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
