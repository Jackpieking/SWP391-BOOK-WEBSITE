using DataAccessLayer.Data.Entites;
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

        //field: Name
        builder
            .Property(propertyExpression: comic => comic.Name)
            .HasColumnType(typeName: VARCHAR_50)
            .IsRequired();

        //field: Description
        builder
            .Property(propertyExpression: comic => comic.Description)
            .HasColumnType(typeName: VARCHAR_1000)
            .IsRequired();

        //field: Description
        builder
            .Property(propertyExpression: comic => comic.PublisherIdentifier)
            .IsRequired();

        //field: LatestChapter
        builder
            .Property(propertyExpression: comic => comic.LatestChapter)
            .IsRequired();

        //field: Avatar
        builder
            .Property(propertyExpression: comic => comic.Avatar)
            .HasColumnType(typeName: VARCHAR_50)
            .IsRequired();

        //field: PublishDate
        builder
            .Property(propertyExpression: comic => comic.PublishDate)
            .IsRequired();

        /**
		 *
		 * Relationship
		 *
		 */
        // One to many: Comic => ComicSaving
        builder
            .HasMany(navigationExpression: comic => comic.ComicSavings)
            .WithOne(navigationExpression: comicSaving => comicSaving.Comic)
            .HasPrincipalKey(keyExpression: comic => comic.ComicIdentifier)
            .HasForeignKey(foreignKeyExpression: comicSaving => comicSaving.ComicIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to many: Comic => ReviewComic
        builder
            .HasMany(navigationExpression: comic => comic.ReviewComics)
            .WithOne(navigationExpression: reviewComic => reviewComic.Comic)
            .HasPrincipalKey(keyExpression: comic => comic.ComicIdentifier)
            .HasForeignKey(foreignKeyExpression: reviewComic => reviewComic.ComicIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to many: Comic => Chapter
        builder
            .HasMany(navigationExpression: comic => comic.Chapters)
            .WithOne(navigationExpression: chapter => chapter.Comic)
            .HasForeignKey(foreignKeyExpression: chapter => chapter.ComicIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade)
            .IsRequired(required: false);

        // One to many: Comic => ComicCategory
        builder
            .HasMany(comic => comic.ComicCategories)
            .WithOne(comicCategory => comicCategory.Comic)
            .HasPrincipalKey(comic => comic.ComicIdentifier)
            .HasForeignKey(comicCategory => comicCategory.ComicIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);
    }
}