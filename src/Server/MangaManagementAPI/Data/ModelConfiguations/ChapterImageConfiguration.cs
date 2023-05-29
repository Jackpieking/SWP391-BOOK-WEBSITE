using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI
{
    public class ChapterImageConfiguration : IEntityTypeConfiguration<ChapterImage>
    {
        public void Configure(EntityTypeBuilder<ChapterImage> builder)
        {
            const string TableName = "Chapter-Image";

            builder.ToTable(name: TableName);

            builder.HasKey(keyExpression: ci => ci.ID);

            builder.Property(propertyExpression: ci => ci.ImageNum)
                    .HasColumnType(typeName: "SMALLINT")
                    .IsRequired();

            builder.Property(propertyExpression: ci => ci.ImageURL)
                    .HasColumnType(typeName: "VARCHAR")
                    .HasMaxLength(maxLength: 200)
                    .IsRequired();

            builder.Property(propertyExpression: ci => ci.ChapterIdentifier)
                    .IsRequired();

            builder.HasIndex(indexExpression: ci => ci.ChapterIdentifier)
                    .IsUnique();
        }
    }
}