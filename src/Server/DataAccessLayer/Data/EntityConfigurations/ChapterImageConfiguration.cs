using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MangaManagementAPI.Data.EntityConfigurations;

public class ChapterImageConfiguration : IEntityTypeConfiguration<ChapterImage>
{
	/// <summary>
	/// Configure ChapterImage table fiels and relationships
	/// </summary>
	/// <param name="builder"></param>
	public void Configure(EntityTypeBuilder<ChapterImage> builder)
	{
		const string TableName = "chapter_image";
		const string VARCHAR_50 = "VARCHAR(50)";
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
			.HasColumnType(typeName: VARCHAR_50)
			.HasDefaultValue(value: string.Empty)
			.IsRequired();

		//field: ChapterIdentifier
		builder
			.Property(propertyExpression: chapterIdentifier => chapterIdentifier.ChapterIdentifier)
			.HasDefaultValue(value: Guid.Empty)
			.IsRequired();
	}
}