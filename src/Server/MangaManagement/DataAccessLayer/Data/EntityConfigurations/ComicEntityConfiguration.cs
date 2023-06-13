using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Data.EntityConfigurations;

public class ComicEntityConfiguration : IEntityTypeConfiguration<ComicEntity>
{
    /// <summary>
    /// Configure Comic table fiels and relationships
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<ComicEntity> builder)
    {
        const string TableName = "comic";
        const string VARCHAR_1000 = "VARCHAR(1000)";
        const string VARCHAR_50 = "VARCHAR(50)";
        const string GEN_RANDOM_UUID = "gen_random_uuid()";

        builder.ToTable(name: TableName);

        //Primary key: ComicIdentifier
        builder.HasKey(keyExpression: comic => comic.ComicIdentifier);

        builder
            .Property(propertyExpression: comic => comic.ComicIdentifier)
            .HasDefaultValueSql(sql: GEN_RANDOM_UUID);

        //field: ComicName
        builder
            .Property(propertyExpression: comic => comic.ComicName)
            .HasColumnType(typeName: VARCHAR_50)
            .IsRequired();

        //field: ComicDescription
        builder
            .Property(propertyExpression: comic => comic.ComicDescription)
            .HasColumnType(typeName: VARCHAR_1000)
            .IsRequired();

        //field: PublisherIdentifier
        builder
            .Property(propertyExpression: comic => comic.PublisherIdentifier)
            .IsRequired();

        //field: ComicLatestChapter
        builder
            .Property(propertyExpression: comic => comic.ComicLatestChapter)
            .IsRequired();

        //field: ComicAvatar
        builder
            .Property(propertyExpression: comic => comic.ComicAvatar)
            .HasColumnType(typeName: VARCHAR_50)
            .IsRequired();

        //field: ComicPublishDate
        builder
            .Property(propertyExpression: comic => comic.ComicPublishedDate)
            .IsRequired();

        /**
		 *
		 * Relationship
		 *
		 */
        // One to many: Comic => ComicSaving
        builder
            .HasMany(navigationExpression: comic => comic.ComicSavingEntities)
            .WithOne(navigationExpression: comicSaving => comicSaving.ComicEntity)
            .HasForeignKey(foreignKeyExpression: comicSaving => comicSaving.ComicIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to many: Comic => ReviewComic
        builder
            .HasMany(navigationExpression: comic => comic.ReviewComicEntities)
            .WithOne(navigationExpression: reviewComic => reviewComic.ComicEntity)
            .HasForeignKey(foreignKeyExpression: reviewComic => reviewComic.ComicIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to many: Comic => Chapter
        builder
            .HasMany(navigationExpression: comic => comic.ChapterEntities)
            .WithOne(navigationExpression: chapter => chapter.ComicEntity)
            .HasForeignKey(foreignKeyExpression: chapter => chapter.ComicIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to many: Comic => ComicCategory
        builder
            .HasMany(comic => comic.ComicCategoryEntities)
            .WithOne(comicCategory => comicCategory.ComicEntity)
            .HasForeignKey(comicCategory => comicCategory.ComicIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to many: Comic => ComicLike
        builder
            .HasMany(navigationExpression: comic => comic.ComicLikeEntities)
            .WithOne(navigationExpression: comicLike => comicLike.ComicEntity)
            .HasForeignKey(foreignKeyExpression: comicLike => comicLike.ComicIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);
    }
}