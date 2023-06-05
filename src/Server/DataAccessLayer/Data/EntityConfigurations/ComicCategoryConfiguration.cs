﻿using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI.Data.EntityConfigurations;

public class ComicCategoryConfiguration : IEntityTypeConfiguration<ComicCategory>
{
	/// <summary>
	/// Configure ComicCategory table fiels and relationships
	/// </summary>
	/// <param name="builder"></param>
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
