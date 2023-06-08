using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI.Data.EntityConfigurations;

public class ReviewChapterConfiguration : IEntityTypeConfiguration<ReviewChapter>
{
    /// <summary>
    /// Configure ReviewChapter table fiels and relationships
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<ReviewChapter> builder)
    {
        const string TableName = "review_chapter";
        const string VARCHAR_200 = "VARCHAR(200)";

        builder.ToTable(name: TableName);

        //Primary - foreign key: [UserIdentifier - ChapterIdentifier]
        builder.HasKey(keyExpression: reviewChapter => new
        {
            reviewChapter.UserIdentifier,
            reviewChapter.ChapterIdentifier
        });

        //field: RatingStar
        builder
            .Property(propertyExpression: reviewChapter => reviewChapter.RatingStar)
            .IsRequired();

        //field: Comment
        builder
            .Property(propertyExpression: reviewChapter => reviewChapter.Comment)
            .HasColumnType(typeName: VARCHAR_200)
            .IsRequired();

        //field: ReviewTime
        builder
            .Property(propertyExpression: reviewChapter => reviewChapter.ReviewTime)
            .IsRequired();
    }
}