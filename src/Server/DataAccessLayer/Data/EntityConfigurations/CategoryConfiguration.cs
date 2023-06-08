using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI.Data.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        /// <summary>
        /// Configure Category table fiels and relationships
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Category> builder)
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

            //field: Name
            builder
                .Property(propertyExpression: category => category.Name)
                .HasColumnType(typeName: VARCHAR_50)
                .IsRequired();

            //field: Description
            builder
                .Property(propertyExpression: category => category.Description)
                .HasColumnType(typeName: VARCHAR_500)
                .IsRequired();

            /**
			 *
			 * Relationship
			 *
			 */
            //One to Many: Category => ComicCategory
            builder
                .HasMany(category => category.ComicCategories)
                .WithOne(comicCategory => comicCategory.Category)
                .HasPrincipalKey(category => category.CategoryIdentifier)
                .HasForeignKey(comicCategory => comicCategory.CategoryIdentifier)
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade)
                .IsRequired(required: false);
        }
    }
}