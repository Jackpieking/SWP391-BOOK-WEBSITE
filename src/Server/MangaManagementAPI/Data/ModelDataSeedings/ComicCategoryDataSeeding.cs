using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace MangaManagementAPI.Data.ModelDataSeedings;

public class ComicCategoryDataSeeding : IEntityTypeConfiguration<ComicCategory>
{
	public void Configure(EntityTypeBuilder<ComicCategory> builder)
	{
		ICollection<ComicCategory> comicCategories = new List<ComicCategory>()
		{
			new()
			{
				CategoryIdentifier = new(g: "414e65b4-1949-48ce-a764-26fb66e95550"),
				ComicIdentifier = new(g: "4dfe12e0-cb8a-4282-8e74-3b1e8053f787"),
			},
			new()
			{
				CategoryIdentifier = new(g: "1b9d5460-4c32-4703-b4bd-c52e5fb6e943"),
				ComicIdentifier = new(g: "4dfe12e0-cb8a-4282-8e74-3b1e8053f787"),
			}
		};

		builder.HasData(data: comicCategories);
	}
}
