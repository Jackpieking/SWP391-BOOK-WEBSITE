using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI
{
    public class ComicConfiguration : IEntityTypeConfiguration<Comic>
    {
        public void Configure(EntityTypeBuilder<Comic> builder)
        {
            const string TableName = "Comic";

            builder.ToTable(name: TableName);

            builder.HasKey(keyExpression: comic => comic.ID);

            builder.Property(propertyExpression: comic => comic.ComicIdentifier)
                    .IsRequired();

            builder.Property(propertyExpression: comic => comic.PubliserIdentifier)
                    .IsRequired();

            builder.Property(propertyExpression: comic => comic.Name)
                    .HasColumnType(typeName: "VARCHAR")
                    .HasMaxLength(50)
                    .IsRequired();

            builder.Property(propertyExpression: comic => comic.Description)
                    .HasColumnType(typeName: "VARCHAR")
                    .HasMaxLength(200)
                    .IsRequired();

            builder.Property(propertyExpression: comic => comic.LatestChapter)
                    .HasColumnType(typeName: "SMALLINT")
                    .IsRequired();

            builder.Property(propertyExpression: comic => comic.Avatar)
                    .HasColumnType(typeName: "VARCHAR")
                    .HasMaxLength(maxLength: 50)
                    .HasDefaultValue("") //default avatar
                    .IsRequired();

            builder.Property(propertyExpression: comic => comic.PublishDate)
                    .HasColumnType(typeName: "DATE")
                    .IsRequired();

            builder.HasIndex(indexExpression: comic => comic.ComicIdentifier)
                .IsUnique();
        }
    }
}