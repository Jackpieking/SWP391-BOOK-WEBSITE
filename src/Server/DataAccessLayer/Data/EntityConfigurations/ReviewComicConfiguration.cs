using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI.Data.EntityConfigurations;

public class ReviewComicConfiguration : IEntityTypeConfiguration<ReviewComic>
{
	/// <summary>
	/// Configure ReviewComic table fiels and relationships
	/// </summary>
	/// <param name="builder"></param>
	public void Configure(EntityTypeBuilder<ReviewComic> builder)
	{
		const string TableName = "review_comic";
		const string VARCHAR_200 = "VARCHAR(200)";
		const string NOW = "now()";

		builder.ToTable(name: TableName);

		//Primary - foreign key: [UserIdentifier - ComicIdentifier]
		builder.HasKey(keyExpression: reviewComic => new
		{
			reviewComic.UserIdentifier,
			reviewComic.ComicIdentifier
		});

		//field: RatingStar
		builder
			.Property(propertyExpression: reviewComic => reviewComic.RatingStar)
			.HasDefaultValue(value: default(short))
			.IsRequired();

		//field: Comment
		builder
			.Property(propertyExpression: reviewComic => reviewComic.Comment)
			.HasColumnType(typeName: VARCHAR_200)
			.HasDefaultValue(value: string.Empty)
			.IsRequired();

		//field: ReviewTime
		builder
			.Property(propertyExpression: reviewComic => reviewComic.ReviewTime)
			.HasDefaultValueSql(sql: NOW)
			.IsRequired();
	}
}