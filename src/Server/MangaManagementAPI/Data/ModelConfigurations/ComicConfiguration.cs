using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI.Data.ModelConfigurations;

public class ComicConfiguration : IEntityTypeConfiguration<Comic>
{
	public void Configure(EntityTypeBuilder<Comic> builder)
	{
		const string TableName = "comic";
		const string VARCHAR_200 = "VARCHAR(200)";
		const string VARCHAR_50 = "VARCHAR(50)";
		const string GEN_RANDOM_UUID = "gen_random_uuid()";
		const string CURRENT_DATE = "CURRENT_DATE";

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
			.HasDefaultValue(value: string.Empty)
			.IsRequired();

		//field: Description
		builder
			.Property(propertyExpression: comic => comic.Description)
			.HasColumnType(typeName: VARCHAR_200)
			.HasDefaultValue(value: string.Empty)
			.IsRequired();

		//field: LatestChapter
		builder
			.Property(propertyExpression: comic => comic.LatestChapter)
			.HasDefaultValue(value: default(double))
			.IsRequired();

		//field: Avatar
		builder
			.Property(propertyExpression: comic => comic.Avatar)
			.HasColumnType(typeName: VARCHAR_50)
			.HasDefaultValue(value: string.Empty)
			.IsRequired();

		//field: PublishDate
		builder
			.Property(propertyExpression: comic => comic.PublishDate)
			.HasDefaultValueSql(sql: CURRENT_DATE)
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
			.OnDelete(deleteBehavior: DeleteBehavior.Cascade)
			.IsRequired(required: false);

		// One to many: Comic => ReviewComic
		builder
			.HasMany(navigationExpression: comic => comic.ReviewComics)
			.WithOne(navigationExpression: reviewComic => reviewComic.Comic)
			.HasPrincipalKey(keyExpression: comic => comic.ComicIdentifier)
			.HasForeignKey(foreignKeyExpression: reviewComic => reviewComic.ComicIdentifier)
			.OnDelete(deleteBehavior: DeleteBehavior.Cascade)
			.IsRequired(required: false);

		// One to many: Comic => Chapter
		builder
			.HasMany(navigationExpression: comic => comic.Chapters)
			.WithOne(navigationExpression: chapter => chapter.Comic)
			.HasPrincipalKey(keyExpression: comic => comic.ComicIdentifier)
			.HasForeignKey(foreignKeyExpression: chapter => chapter.ComicIdentifier)
			.OnDelete(deleteBehavior: DeleteBehavior.Cascade)
			.IsRequired();

		// One to many: Comic => ComicCategory
		builder
			.HasMany(comic => comic.ComicCategories)
			.WithOne(comicCategory => comicCategory.Comic)
			.HasPrincipalKey(comic => comic.ComicIdentifier)
			.HasForeignKey(comicCategory => comicCategory.ComicIdentifier)
			.OnDelete(DeleteBehavior.Cascade)
			.IsRequired(required: false);
	}
}