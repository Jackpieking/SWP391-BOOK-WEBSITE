using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Data.EntityConfigurations;

public class CategoryEntityConfiguration : IEntityTypeConfiguration<CategoryEntity>
{
    /// <summary>
    /// Configure Category table fiels and relationships
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<CategoryEntity> builder)
    {

        const string TableName = "category";
        const string VARCHAR_50 = "VARCHAR(50)";
        const string VARCHAR_500 = "VARCHAR(500)";
        const string GEN_RANDOM_UUID = "gen_random_uuid()";

        builder.ToTable(name: TableName);

        //Primary key: CategoryIdentifier
        builder.HasKey(keyExpression: category => category.CategoryIdentifier);

        builder
            .Property(propertyExpression: category => category.CategoryIdentifier)
            .HasDefaultValueSql(sql: GEN_RANDOM_UUID);

        //field: CategoryName
        builder
            .Property(propertyExpression: category => category.CategoryName)
            .HasColumnType(typeName: VARCHAR_50)
            .IsRequired();

        //field: CategoryDescription
        builder
            .Property(propertyExpression: category => category.CategoryDescription)
            .HasColumnType(typeName: VARCHAR_500)
            .IsRequired();

        /**
			 *
			 * Relationship
			 *
			 */
        //One to Many: Category => ComicCategory
        builder
            .HasMany(category => category.ComicCategoryEntities)
            .WithOne(comicCategory => comicCategory.CategoryEntity)
            .HasPrincipalKey(category => category.CategoryIdentifier)
            .HasForeignKey(comicCategory => comicCategory.CategoryIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade)
            .IsRequired(required: false);
    }
}