using DataAccessLayer.Data.EntityConfigurations;
using DataAccessLayer.Data.EntityDataSeedings;
using DataAccessLayer.Data.ModelDataSeedings;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Data;

public class MangaContext : DbContext
{
    /// <summary>
    /// Representation of each table in the Manga database
    /// </summary>
    #region DbSet
    public DbSet<UserEntity> UserInfos { get; set; }

    public DbSet<TransactionsHistoryEntity> TransactionsHistories { get; set; }

    public DbSet<CategoryEntity> Categories { get; set; }

    public DbSet<ChapterEntity> Chapters { get; set; }

    public DbSet<ChapterImageEntity> ChapterImages { get; set; }

    public DbSet<ComicEntity> Comics { get; set; }

    public DbSet<ComicSavingEntity> ComicSavings { get; set; }

    public DbSet<ReviewChapterEntity> ReviewChapters { get; set; }

    public DbSet<ReviewComicEntity> ReviewComics { get; set; }

    public DbSet<ReadingHistoryEntity> ReadingHistories { get; set; }

    public DbSet<ComicCategoryEntity> ComicCategories { get; set; }

    public DbSet<PublisherEntity> PublisherEntities { get; set; }

    public DbSet<BuyingHistoryEntity> BuyingHistoryEntities { get; set; }

    public DbSet<ComicLikeEntity> ComicLikeEntities { get; set; }
    #endregion

    public MangaContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        /**
		 * Configuration for each table of the Manga database
		 */
        #region EntityConfiguration
        modelBuilder
            .ApplyConfiguration(configuration: new UserEntityConfiguration())
            .ApplyConfiguration(configuration: new TransactionsHistoryEntityConfiguration())
            .ApplyConfiguration(configuration: new ReviewComicEntityConfiguration())
            .ApplyConfiguration(configuration: new ReviewChapterEntityConfiguration())
            .ApplyConfiguration(configuration: new ReadingHistoryEntityConfiguration())
            .ApplyConfiguration(configuration: new ComicSavingEntityConfiguration())
            .ApplyConfiguration(configuration: new ComicCategoryEntityConfiguration())
            .ApplyConfiguration(configuration: new ComicEntityConfiguration())
            .ApplyConfiguration(configuration: new ChapterImageEntityConfiguration())
            .ApplyConfiguration(configuration: new ChapterEntityConfiguration())
            .ApplyConfiguration(configuration: new CategoryEntityConfiguration())
            .ApplyConfiguration(configuration: new PublisherEntityConfiguration())
            .ApplyConfiguration(configuration: new BuyingHistoryEntityConfiguration())
            .ApplyConfiguration(configuration: new ComicLikeEntityConfiguration());
        #endregion

        /**
		 * Seeding data for each table of the Manga Database
		 */
        #region EntityDataSeeding
        modelBuilder
            .ApplyConfiguration(configuration: new UserEntityDataSeeding())
            .ApplyConfiguration(configuration: new TransactionHistoryEntityDataSeeding())
            .ApplyConfiguration(configuration: new ReviewComicEntityDataSeeding())
            .ApplyConfiguration(configuration: new ReviewChapterEntityDataSeeding())
            .ApplyConfiguration(configuration: new ReadingHistoryEntityDataSeeding())
            .ApplyConfiguration(configuration: new ComicSavingEntityDataSeeding())
            .ApplyConfiguration(configuration: new ComicEntityDataSeeding())
            .ApplyConfiguration(configuration: new ComicCategoryEntityDataSeeding())
            .ApplyConfiguration(configuration: new ChapterImageEntityDataSeeding())
            .ApplyConfiguration(configuration: new ChapterEntityDataSeeding())
            .ApplyConfiguration(configuration: new CategoryEntityDataSeeding())
            .ApplyConfiguration(configuration: new PublisherEntityDataSeeding())
            .ApplyConfiguration(configuration: new ComicLikeEntityDataSeeding());
        #endregion
    }
}
