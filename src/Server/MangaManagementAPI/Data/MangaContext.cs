using MangaManagementAPI.Data.ModelConfiguations;
using MangaManagementAPI.Data.ModelDataSeedings;
using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace MangaManagementAPI.Data;

public class MangaContext : DbContext
{
	public DbSet<UserInfo> UserAccess { get; set; }

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
            .ApplyConfiguration(new LoginAccountConfiguration())
            .ApplyConfiguration(new UserAccessConfiguration())
            .ApplyConfiguration(new ComicConfiguration())
            .ApplyConfiguration(new ChapterConfiguration())
            .ApplyConfiguration(new ChapterImageConfiguration())
            .ApplyConfiguration(new ComicSavingConfiguration())
            .ApplyConfiguration(new ReadingHistoryConfiguration())
            .ApplyConfiguration(new ReviewComicConfiguration())
            .ApplyConfiguration(new TransactionsHistoryConfiguration())
            .ApplyConfiguration(new ReadingHistoryConfiguration())
            .ApplyConfiguration(new UserAccessConfiguration());

        //Data seeding
        modelBuilder
            .ApplyConfiguration(new UserAccessDataSeeding());
    }


    private ILoggerFactory GetLoggerFactory()
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        serviceCollection.AddLogging(builder =>
                builder.AddConsole()
                    .AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.Information));

        var service = serviceCollection.BuildServiceProvider()
                                        .GetService<ILoggerFactory>();
        return service;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseLoggerFactory(GetLoggerFactory());

    }
}
