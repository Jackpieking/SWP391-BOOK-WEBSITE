using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Data.EntityConfigurations;

public class PublisherEntityConfiguration : IEntityTypeConfiguration<PublisherEntity>
{
    /// <summary>
    /// Configure Publisher table fiels and relationships
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<PublisherEntity> builder)
    {
        const string TableName = "publisher";
        const string VARCHAR_200 = "VARCHAR(200)";
        const string GEN_RANDOM_UUID = "gen_random_uuid()";

        builder.ToTable(name: TableName);

        //primary key: PublisherIdentifer
        builder.HasKey(keyExpression: publisher => publisher.PublisherIdentifier);

        //field: PublisherIdentifer
        builder
            .Property(propertyExpression: publisher => publisher.PublisherIdentifier)
            .HasDefaultValueSql(sql: GEN_RANDOM_UUID);

        //field: ChapterIdentifier
        builder
            .Property(propertyExpression: publisher => publisher.UserIdentifier)
            .IsRequired();

        //field: PublisherDescription
        builder
            .Property(propertyExpression: publisher => publisher.PublisherDescription)
            .HasColumnType(typeName: VARCHAR_200)
            .IsRequired();

        /**
         *
         * Relationship
         *
         */
        // One to many: Publisher => Comic
        builder
            .HasMany(navigationExpression: publisher => publisher.ComicEntities)
            .WithOne(navigationExpression: comic => comic.PublisherEntity)
            .HasForeignKey(foreignKeyExpression: comic => comic.PublisherIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.NoAction);
    }
}
