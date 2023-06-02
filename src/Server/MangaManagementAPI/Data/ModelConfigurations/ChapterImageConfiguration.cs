using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MangaManagementAPI.Data.ModelConfigurations;

public class ChapterImageConfiguration : IEntityTypeConfiguration<ChapterImage>
{
	public void Configure(EntityTypeBuilder<ChapterImage> builder)
	{
		const string TableName = "chapter_image";
		const string VARCHAR_30 = "VARCHAR(30)";
		const string GEN_RANDOM_UUID = "gen_random_uuid()";

		builder.ToTable(name: TableName);

		//Primary key: ImageIdentifier
		builder.HasKey(keyExpression: chapterImage => chapterImage.ImageIdentifier);

		builder
			.Property(propertyExpression: chapterImage => chapterImage.ImageIdentifier)
			.HasDefaultValueSql(sql: GEN_RANDOM_UUID);

		//field: ImageNumber
		builder
			.Property(propertyExpression: chapterImage => chapterImage.ImageNumber)
			.HasDefaultValue(value: default(short))
			.IsRequired();

		//field: ImageURL
		builder
			.Property(propertyExpression: chapterImage => chapterImage.ImageURL)
			.HasColumnType(typeName: VARCHAR_30)
			.HasDefaultValue(value: string.Empty)
			.IsRequired();

		//field: ChapterIdentifier
		builder
			.Property(propertyExpression: chapterIdentifier => chapterIdentifier.ChapterIdentifier)
			.HasDefaultValue(value: Guid.Empty)
			.IsRequired();
	}
}