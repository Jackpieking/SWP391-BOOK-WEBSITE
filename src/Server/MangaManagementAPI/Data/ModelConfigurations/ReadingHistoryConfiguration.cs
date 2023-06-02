using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MangaManagementAPI.Data.ModelConfigurations;

public class ReadingHistoryConfiguration : IEntityTypeConfiguration<ReadingHistory>
{
	public void Configure(EntityTypeBuilder<ReadingHistory> builder)
	{
		const string TableName = "reading_history";

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
			.HasDefaultValue(value: DateTime.UtcNow)
			.IsRequired();
	}
}