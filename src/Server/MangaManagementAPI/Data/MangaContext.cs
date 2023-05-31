using MangaManagementAPI.Data.ModelConfiguations;
using MangaManagementAPI.Data.ModelDataSeedings;
using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MangaManagementAPI.Data;

public class MangaContext : DbContext
{
	public DbSet<UserInfo> UserAccess { get; set; }

	public MangaContext(DbContextOptions options) : base(options) { }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		//table configuration
		modelBuilder
			.ApplyConfiguration(new UserAccessConfiguration());

		//Data seeding
		modelBuilder
			.ApplyConfiguration(new UserAccessDataSeeding());
	}
}
