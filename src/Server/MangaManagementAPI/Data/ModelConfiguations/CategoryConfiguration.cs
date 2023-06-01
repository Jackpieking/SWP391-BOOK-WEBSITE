using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            const string TableName = "Category";

            builder.ToTable(name: TableName);

            builder.HasKey(keyExpression: category => category.ID);

            builder.Property(propertyExpression: category => category.Name)
                    .HasColumnType(typeName: "VARCHAR")
                    .HasMaxLength(maxLength: 50)
                    .IsRequired();

            builder.Property(propertyExpression: category => category.Description)
                    .HasColumnType(typeName: "VARCHAR")
                    .HasMaxLength(maxLength: 200)
                    .IsRequired();

            builder.Property(propertyExpression: category => category.CategoryIdentifier)
                    .IsRequired();

            builder.HasIndex(indexExpression: category => category.CategoryIdentifier)
                    .IsUnique();
        }
    }
}