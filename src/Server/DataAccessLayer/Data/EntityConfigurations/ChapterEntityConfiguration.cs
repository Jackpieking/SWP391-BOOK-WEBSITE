using Entity;
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

        //field: ChapterUnlockPrice
        builder
            .Property(propertyExpression: chapter => chapter.ChapterUnlockPrice)
            .IsRequired();

        //field: AddedDate
        builder
            .Property(propertyExpression: chapter => chapter.AddedDate)
            .IsRequired();

        /**
		 *
		 * Relationship
		 *
		 */
        // One to many: Chapter => ReadingHistory
        builder
            .HasMany(navigationExpression: chapter => chapter.ReadingHistoryEntities)
            .WithOne(navigationExpression: readingHistory => readingHistory.ChapterEntity)
            .HasPrincipalKey(keyExpression: chapter => chapter.ChapterIdentifier)
            .HasForeignKey(foreignKeyExpression: readingHistory => readingHistory.ChapterIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to many: Chapter => ReviewChapter
        builder
            .HasMany(navigationExpression: chapter => chapter.ReviewChapterEntities)
            .WithOne(navigationExpression: reviewChapter => reviewChapter.ChapterEntity)
            .HasPrincipalKey(keyExpression: chapter => chapter.ChapterIdentifier)
            .HasForeignKey(foreignKeyExpression: reviewChapter => reviewChapter.ChapterIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to many: Chapter => ChapterImage
        builder
            .HasMany(navigationExpression: chapter => chapter.ChapterImageEntities)
            .WithOne(navigationExpression: chapterImage => chapterImage.ChapterEntity)
            .HasForeignKey(foreignKeyExpression: chapterImage => chapterImage.ChapterIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to many: Chapter => BuyingHistory
        builder
            .HasMany(navigationExpression: chapter => chapter.BuyingHistoryEntities)
            .WithOne(navigationExpression: buyingHistory => buyingHistory.ChapterEntity)
            .HasForeignKey(foreignKeyExpression: buyingHistory => buyingHistory.UserIdentifer)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);
    }
}