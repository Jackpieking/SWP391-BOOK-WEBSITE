using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI.Data.ModelConfigurations;

public class ComicCategoryConfiguration : IEntityTypeConfiguration<ComicCategory>
{
	public void Configure(EntityTypeBuilder<ComicCategory> builder)
	{
		const string TableName = "comic_category";

		builder.ToTable(name: TableName);

		//Primary - foreign key: [CategoriesIdentifier - ComicIdentifier]
		builder.HasKey(keyExpression: comicCategory => new
		{
			comicCategory.CategoryIdentifier,
			comicCategory.ComicIdentifier
		});
	}
}
