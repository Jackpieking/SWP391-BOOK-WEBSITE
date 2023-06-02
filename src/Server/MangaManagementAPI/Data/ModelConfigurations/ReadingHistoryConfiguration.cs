using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI.Data.ModelConfigurations;

public class ReadingHistoryConfiguration : IEntityTypeConfiguration<ReadingHistory>
{
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