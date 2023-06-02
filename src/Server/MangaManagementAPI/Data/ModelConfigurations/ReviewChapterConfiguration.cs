using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI.Data.ModelConfigurations;

public class ReviewChapterConfiguration : IEntityTypeConfiguration<ReviewChapter>
{
	public void Configure(EntityTypeBuilder<ReviewChapter> builder)
	{
		const string TableName = "review_chapter";
		const string VARCHAR_200 = "VARCHAR(200)";
		const string NOW = "now()";

		builder.ToTable(name: TableName);

		//Primary - foreign key: [UserIdentifier - ChapterIdentifier]
		builder.HasKey(keyExpression: reviewChapter => new
		{
			reviewChapter.UserIdentifier,
			reviewChapter.ChapterIdentifier
		});

		//field: RatingStar
		builder
			.Property(propertyExpression: reviewChapter => reviewChapter.RatingStar)
			.HasDefaultValue(value: default(short))
			.IsRequired();

		//field: Comment
		builder
			.Property(propertyExpression: reviewChapter => reviewChapter.Comment)
			.HasColumnType(typeName: VARCHAR_200)
			.HasDefaultValue(value: string.Empty)
			.IsRequired();

		//field: ReviewTime
		builder
			.Property(propertyExpression: reviewChapter => reviewChapter.ReviewTime)
			.HasDefaultValueSql(sql: NOW)
			.IsRequired();
	}
}