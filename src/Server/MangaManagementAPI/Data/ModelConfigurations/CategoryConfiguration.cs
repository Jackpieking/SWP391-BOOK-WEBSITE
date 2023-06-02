using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace MangaManagementAPI
{
	public class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			const string TableName = "category";
			const string VARCHAR_50 = "VARCHAR(50)";
			const string VARCHAR_200 = "VARCHAR(200)";

			builder.ToTable(name: TableName);

			//Primary key: CategoryIdentifier
			builder.HasKey(keyExpression: category => category.CategoryIdentifier);

			builder
				.Property(propertyExpression: category => category.CategoryIdentifier)
				.HasValueGenerator<GuidValueGenerator>();

			//field: Name
			builder
				.Property(propertyExpression: category => category.Name)
				.HasColumnType(typeName: VARCHAR_50)
				.HasDefaultValue(value: string.Empty)
				.IsRequired();

			//field: Description
			builder
				.Property(propertyExpression: category => category.Description)
				.HasColumnType(typeName: VARCHAR_200)
				.HasDefaultValue(value: string.Empty)
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