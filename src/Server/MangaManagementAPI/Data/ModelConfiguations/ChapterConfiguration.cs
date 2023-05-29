using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI
{
    public class ChapterConfiguration : IEntityTypeConfiguration<Chapter>
    {
        public void Configure(EntityTypeBuilder<Chapter> builder)
        {
            const string TableName = "Chapter";

            builder.ToTable(name: TableName);

            builder.HasKey(keyExpression: chapter => chapter.ID);

            builder.Property(propertyExpression: chapter => chapter.ChapterNumber)
                    .HasColumnType(typeName: "SMALLINT")
                    .IsRequired();

            builder.Property(propertyExpression: chapter => chapter.UnlockPrice)
                    .HasColumnType(typeName: "SMALLINT")
                    .IsRequired(false); //Some chapters have

            builder.Property(propertyExpression: chapter => chapter.ComicIdentifier)
                    .IsRequired();

            builder.Property(propertyExpression: chapter => chapter.ChapterIdentifier)
                    .IsRequired();

            builder.HasIndex(indexExpression: chapter => chapter.ComicIdentifier)
                    .IsUnique();

            builder.HasIndex(indexExpression: chapter => chapter.ChapterIdentifier)
                    .IsUnique();
        }
    }
}