using DataAccessLayer.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Data.EntityConfigurations;

public class ChapterImageEntityConfiguration : IEntityTypeConfiguration<ChapterImageEntity>
{
    /// <summary>
    /// Configure ChapterImage table fiels and relationships
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<ChapterImageEntity> builder)
    {
        const string TableName = "chapter_image";
        const string VARCHAR_50 = "VARCHAR(50)";
        const string GEN_RANDOM_UUID = "gen_random_uuid()";

        builder.ToTable(name: TableName);

        //Primary key: ImageIdentifier
        builder.HasKey(keyExpression: chapterImage => chapterImage.ImageIdentifier);

        builder
            .Property(propertyExpression: chapterImage => chapterImage.ImageIdentifier)
            .HasDefaultValueSql(sql: GEN_RANDOM_UUID);

        //field: ImageNumber
        builder
            .Property(propertyExpression: chapterImage => chapterImage.ImageNumber)
            .IsRequired();

        //field: ImageURL
        builder
            .Property(propertyExpression: chapterImage => chapterImage.ImageURL)
            .HasColumnType(typeName: VARCHAR_50)
            .IsRequired();
    }
}