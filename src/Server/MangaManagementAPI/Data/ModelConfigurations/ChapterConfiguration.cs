using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MangaManagementAPI.Data.ModelConfigurations;

public class ChapterConfiguration : IEntityTypeConfiguration<Chapter>
{
	public void Configure(EntityTypeBuilder<Chapter> builder)
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
			.HasDefaultValue(value: default(double))
			.IsRequired();

		//field: UnlockPrice
		builder
			.Property(propertyExpression: chapter => chapter.UnlockPrice)
			.HasDefaultValue(value: default(int))
			.IsRequired();

		//Foreign Key: ComicIdentifier
		builder
			.Property(propertyExpression: chapter => chapter.ComicIdentifier)
			.HasDefaultValue(value: Guid.Empty)
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
			.OnDelete(deleteBehavior: DeleteBehavior.Cascade)
			.IsRequired(required: false);

		// One to many: Chapter => ReviewChapter
		builder
			.HasMany(navigationExpression: chapter => chapter.ReviewChapters)
			.WithOne(navigationExpression: reviewChapter => reviewChapter.Chapter)
			.HasPrincipalKey(keyExpression: chapter => chapter.ChapterIdentifier)
			.HasForeignKey(foreignKeyExpression: reviewChapter => reviewChapter.ChapterIdentifier)
			.OnDelete(deleteBehavior: DeleteBehavior.Cascade)
			.IsRequired(required: false);

		// One to many: Chapter => ChapterImage
		builder
			.HasMany(navigationExpression: chapter => chapter.ChapterImages)
			.WithOne(navigationExpression: chapterImage => chapterImage.Chapter)
			.HasPrincipalKey(keyExpression: chapter => chapter.ChapterIdentifier)
			.HasForeignKey(foreignKeyExpression: chapterImage => chapterImage.ChapterIdentifier)
			.OnDelete(deleteBehavior: DeleteBehavior.Cascade)
			.IsRequired();
	}
}