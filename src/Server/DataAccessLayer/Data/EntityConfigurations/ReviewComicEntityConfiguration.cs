using DataAccessLayer.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Data.EntityConfigurations;

public class ReviewComicEntityConfiguration : IEntityTypeConfiguration<ReviewComicEntity>
{
    /// <summary>
    /// Configure ReviewComic table fiels and relationships
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<ReviewComicEntity> builder)
    {
        const string TableName = "review_comic";
        const string VARCHAR_200 = "VARCHAR(200)";

        builder.ToTable(name: TableName);

        //Primary - foreign key: [UserIdentifier - ComicIdentifier]
        builder.HasKey(keyExpression: reviewComic => new
        {
            reviewComic.UserIdentifier,
            reviewComic.ComicIdentifier
        });

        //field: RatingStar
        builder
            .Property(propertyExpression: reviewComic => reviewComic.RatingStar)
            .IsRequired();

        //field: Comment
        builder
            .Property(propertyExpression: reviewComic => reviewComic.Comment)
            .HasColumnType(typeName: VARCHAR_200)
            .IsRequired();

        //field: ReviewTime
        builder
            .Property(propertyExpression: reviewComic => reviewComic.ReviewTime)
            .IsRequired();
    }
}