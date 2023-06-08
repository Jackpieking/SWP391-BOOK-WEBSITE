using DataAccessLayer.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Data.EntityConfigurations;

public class ReadingHistoryEntityConfiguration : IEntityTypeConfiguration<ReadingHistoryEntity>
{
    /// <summary>
    /// Configure ReadingHistory table fiels and relationships
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<ReadingHistoryEntity> builder)
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
            .IsRequired();
    }
}