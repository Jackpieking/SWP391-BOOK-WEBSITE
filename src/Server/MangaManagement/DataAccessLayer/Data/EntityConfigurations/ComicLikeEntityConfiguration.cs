using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Data.EntityConfigurations;

public class ComicLikeEntityConfiguration : IEntityTypeConfiguration<ComicLikeEntity>
{
    /// <summary>
    /// Configure ComicLike table fiels and relationships
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<ComicLikeEntity> builder)
    {
        const string TableName = "comic_like";

        builder.ToTable(name: TableName);

        //Primary - foreign key: [UserIdentifier - ChapterIdetifier]
        builder.HasKey(keyExpression: comicLike => new
        {
            comicLike.UserIdentifier,
            comicLike.ComicIdentifier
        });
    }
}
