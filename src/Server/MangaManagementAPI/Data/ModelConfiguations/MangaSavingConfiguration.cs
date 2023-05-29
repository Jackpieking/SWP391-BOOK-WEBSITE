using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI
{
    public class MangaSavingConfiguration : IEntityTypeConfiguration<MangaSaving>
    {
        public void Configure(EntityTypeBuilder<MangaSaving> builder)
        {
            const string TableName = "Manga-Saving";

            builder.ToTable(name: TableName);

            builder.HasKey(keyExpression: ms => ms.ID);

            builder.Property(propertyExpression: ms => ms.UserIdentifier)
                    .IsRequired();

            builder.Property(propertyExpression: ms => ms.ChapterIdentifier)
                    .IsRequired();

            builder.Property(propertyExpression: ms => ms.ComicIdentifier)
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