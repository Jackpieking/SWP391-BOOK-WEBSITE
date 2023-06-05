using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI.Data.EntityConfigurations;

public class ReadingHistoryConfiguration : IEntityTypeConfiguration<ReadingHistory>
{
	/// <summary>
	/// Configure ReadingHistory table fiels and relationships
	/// </summary>
	/// <param name="builder"></param>
	public void Configure(EntityTypeBuilder<ReadingHistory> builder)
	{
		const string TableName = "reading_history";
		const string NOW = "now()";

		builder.ToTable(name: TableName);

		//Primary - foreign key: [UserIdentifier - ChapterIdetifier]
		builder.HasKey(keyExpression: readingHistory => new
		{
			readingHistory.UserIdentifier,
			readingHistory.ChapterIdentifier
		});

		//field: LastReadingTime
		builder
			.Property(propertyExpression: readingHistory => readingHistory.LastReadingTime)
			.HasDefaultValueSql(sql: NOW)
			.IsRequired();
	}
}