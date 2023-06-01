using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI
{
    public class ReadingHistoryConfiguration : IEntityTypeConfiguration<ReadingHistory>
    {
        public void Configure(EntityTypeBuilder<ReadingHistory> builder)
        {
            const string TableName = "Reading-History";

            builder.ToTable(name: TableName);

            builder.HasKey(keyExpression: rh => rh.ID);

            builder.Property(propertyExpression: rh => rh.ReadOn)
                    .HasColumnType(typeName: "DATETIME")
                    .IsRequired();

            builder.Property(propertyExpression: rh => rh.UserIdentifier)
                    .IsRequired();

            builder.Property(propertyExpression: rh => rh.ChapterIdentifier)
                    .IsRequired();

            builder.Property(propertyExpression: rh => rh.ComicIdentifier)
                    .IsRequired();

            builder.HasIndex(indexExpression: ms => ms.UserIdentifier)
                    .IsUnique();

            builder.HasIndex(indexExpression: ms => ms.ComicIdentifier)
                    .IsUnique();

            builder.HasIndex(indexExpression: ms => ms.ChapterIdentifier)
                    .IsUnique();
        }
    }
}