using DataAccessLayer.Data.EntityConfigurations;
using DataAccessLayer.Data.EntityDataSeedings;
using MangaManagementAPI.Data.Entites;
using MangaManagementAPI.Data.EntityConfigurations;
using MangaManagementAPI.Data.EntityDataSeedings;
using MangaManagementAPI.Data.ModelDataSeedings;
using Microsoft.EntityFrameworkCore;

namespace MangaManagementAPI.Data;

public class MangaContext : DbContext
{
    /// <summary>
    /// Representation of each table in the Manga database
    /// </summary>
    #region DbSet
    public DbSet<UserInfo> UserInfos { get; set; }

    public DbSet<TransactionsHistory> TransactionsHistories { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Chapter> Chapters { get; set; }

    public DbSet<ChapterImage> ChapterImages { get; set; }

    public DbSet<Comic> Comics { get; set; }

    public DbSet<ComicSaving> ComicSavings { get; set; }

    public DbSet<ReviewChapter> ReviewChapters { get; set; }

    public DbSet<ReviewComic> ReviewComics { get; set; }

    public DbSet<ReadingHistory> ReadingHistories { get; set; }

    public DbSet<ComicCategory> ComicCategories { get; set; }
    #endregion

    public MangaContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        /**
		 * Configuration for each table of the Manga database
		 */
        #region EntityConfiguration
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
            .ApplyConfiguration(configuration: new CategoryConfiguration())
            .ApplyConfiguration(configuration: new PublisherConfiguration())
            .ApplyConfiguration(configuration: new BuyingHistoryConfiguration());
        #endregion

        /**
		 * Seeding data for each table of the Manga Database
		 */
        #region EntityDataSeeding
        modelBuilder
            .ApplyConfiguration(configuration: new UserInfoDataSeeding())
            .ApplyConfiguration(configuration: new TransactionHistoryDataSeeding())
            .ApplyConfiguration(configuration: new ReviewComicDataSeeding())
            .ApplyConfiguration(configuration: new ReviewChapterDataSeeding())
            .ApplyConfiguration(configuration: new ReadingHistoryDataSeeding())
            .ApplyConfiguration(configuration: new ComicSavingDataSeeding())
            .ApplyConfiguration(configuration: new ComicDataSeeding())
            .ApplyConfiguration(configuration: new ComicCategoryDataSeeding())
            .ApplyConfiguration(configuration: new ChapterImageDataSeeding())
            .ApplyConfiguration(configuration: new ChapterDataSeeding())
            .ApplyConfiguration(configuration: new CategoryDataSeeding())
            .ApplyConfiguration(configuration: new PublisherDataSeeding());
        #endregion
    }
}
