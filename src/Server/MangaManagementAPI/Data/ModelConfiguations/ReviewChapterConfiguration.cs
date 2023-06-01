using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI
{
    public class ReviewChapterConfiguration : IEntityTypeConfiguration<ReviewChapter>
    {
        public void Configure(EntityTypeBuilder<ReviewChapter> builder)
        {
            const string TableName = "Review-Chapter";

            builder.ToTable(name: TableName);

            builder.HasKey(keyExpression: rc => rc.ID);

            builder.Property(propertyExpression: rc => rc.RatingStart)
                    .HasColumnType(typeName: "SMALLINT")
                    .IsRequired();

            builder.Property(propertyExpression: rc => rc.Comment)
                    .HasColumnType(typeName: "VARCHAR")
                    .HasMaxLength(200)
                    .IsRequired(); //consider some users just leave star and no comment

            builder.Property(propertyExpression: rc => rc.Time)
                    .HasColumnType(typeName: "TIMESTAMP")
                    .IsRequired();

            builder.Property(propertyExpression: rc => rc.UserIdentifier)
                    .IsRequired();

            builder.Property(propertyExpression: rc => rc.ChapterIdentifier)
                    .IsRequired();

                        
            builder.HasIndex(indexExpression: rc => rc.UserIdentifier)
                    .IsUnique();

            builder.HasIndex(indexExpression: rc => rc.ChapterIdentifier)
                    .IsUnique();
        }
    }
}