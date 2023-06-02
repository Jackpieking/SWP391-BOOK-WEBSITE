using MangaManagementAPI.Data.ModelConfigurations;
using MangaManagementAPI.Data.ModelDataSeedings;
using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MangaManagementAPI.Data;

public class MangaContext : DbContext
{
	public DbSet<UserInfo> UserInfo { get; set; }

	public DbSet<TransactionsHistory> TransactionsHistories { get; set; }

	public DbSet<Category> Categories { get; set; }

	public DbSet<Chapter> Chapters { get; set; }

	public DbSet<ChapterImage> ChapterImages { get; set; }

	public DbSet<Comic> Comics { get; set; }

	public DbSet<ComicSaving> ComicSavings { get; set; }

	public DbSet<ReviewChapter> ReviewChapters { get; set; }

	public DbSet<ReviewComic> ReviewComics { get; set; }

	public DbSet<ReadingHistory> ReadingHistories { get; set; }

	public MangaContext(DbContextOptions options) : base(options) { }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		//table configuration
		modelBuilder
			.ApplyConfiguration(configuration: new UserInfoConfiguration())
			.ApplyConfiguration(configuration: new TransactionsHistoryConfiguration())
			.ApplyConfiguration(configuration: new ReviewComicConfiguration())
			.ApplyConfiguration(configuration: new ReviewChapterConfiguration())
			.ApplyConfiguration(configuration: new ReadingHistoryConfiguration())
			.ApplyConfiguration(configuration: new ComicSavingConfiguration())
			.ApplyConfiguration(configuration: new ComicCategoryConfiguration())
			.ApplyConfiguration(configuration: new ComicConfiguration())
			.ApplyConfiguration(configuration: new ChapterImageConfiguration())
			.ApplyConfiguration(configuration: new ChapterConfiguration())
			.ApplyConfiguration(configuration: new CategoryConfiguration());

		//Data seeding
		modelBuilder
			.ApplyConfiguration(configuration: new UserInfoDataSeeding())
			.ApplyConfiguration(configuration: new TransactionHistoryDataSeeding())
			.ApplyConfiguration(configuration: new ReviewComicDataSeeding());
	}
}
