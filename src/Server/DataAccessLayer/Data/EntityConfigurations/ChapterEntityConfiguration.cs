using DataAccessLayer.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Data.EntityConfigurations;

public class ChapterEntityConfiguration : IEntityTypeConfiguration<ChapterEntity>
{
    /// <summary>
    /// Configure Chapter table fiels and relationships
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<ChapterEntity> builder)
    {
        const string TableName = "chapter";
        const string GEN_RANDOM_UUID = "gen_random_uuid()";

        builder.ToTable(name: TableName);

        //Primary key: ChapterIdentifier
        builder.HasKey(keyExpression: chapter => chapter.ChapterIdentifier);

        builder
            .Property(propertyExpression: chapter => chapter.ChapterIdentifier)
            .HasDefaultValueSql(sql: GEN_RANDOM_UUID);

        //field: ChapterNumber
        builder
            .Property(propertyExpression: chapter => chapter.ChapterNumber)
            .IsRequired();

        //field: UnlockPrice
        builder
            .Property(propertyExpression: chapter => chapter.UnlockPrice)
            .IsRequired();

        /**
		 *
		 * Relationship
		 *
		 */
        // One to many: Chapter => ReadingHistory
        builder
            .HasMany(navigationExpression: chapter => chapter.ReadingHistories)
            .WithOne(navigationExpression: readingHistory => readingHistory.Chapter)
            .HasPrincipalKey(keyExpression: chapter => chapter.ChapterIdentifier)
            .HasForeignKey(foreignKeyExpression: readingHistory => readingHistory.ChapterIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to many: Chapter => ReviewChapter
        builder
            .HasMany(navigationExpression: chapter => chapter.ReviewChapters)
            .WithOne(navigationExpression: reviewChapter => reviewChapter.Chapter)
            .HasPrincipalKey(keyExpression: chapter => chapter.ChapterIdentifier)
            .HasForeignKey(foreignKeyExpression: reviewChapter => reviewChapter.ChapterIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to many: Chapter => ChapterImage
        builder
            .HasMany(navigationExpression: chapter => chapter.ChapterImages)
            .WithOne(navigationExpression: chapterImage => chapterImage.Chapter)
            .HasForeignKey(foreignKeyExpression: chapterImage => chapterImage.ChapterIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to many: Chapter => BuyingHistory
        builder
            .HasMany(navigationExpression: chapter => chapter.BuyingHistories)
            .WithOne(navigationExpression: buyingHistory => buyingHistory.Chapter)
            .HasForeignKey(foreignKeyExpression: buyingHistory => buyingHistory.UserIdentifer)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);
    }
}