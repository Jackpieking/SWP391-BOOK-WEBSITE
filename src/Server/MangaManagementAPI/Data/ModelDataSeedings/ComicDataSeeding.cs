using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace MangaManagementAPI.Data.ModelDataSeedings;

public class ComicDataSeeding : IEntityTypeConfiguration<Comic>
{
	public void Configure(EntityTypeBuilder<Comic> builder)
	{
		ICollection<Comic> comics = new List<Comic>()
		{
			new()
			{
				ComicIdentifier = Guid.Parse(input: "4dfe12e0-cb8a-4282-8e74-3b1e8053f787"),
				Name = "Superhero Comic",
				Description = "This comic follows the adventures of a group of superheroes in a universe of superpowers and evil villains.",
				PublishDate = new(year: 2014, month: 1, day: 1),
				LatestChapter = 1
			},
			new()
			{
				ComicIdentifier = Guid.Parse(input: "aadadaf7-fc21-4559-a53c-f97eb1ba583f"),
				Name = "Fantasy Comic",
				Description = "This comic follows the adventures of a group of fantasy heroes in a universe of magic and mysticism.",
				PublishDate = new(year: 2015, month: 2, day: 1),
				LatestChapter = 8
			},
			new()
			{
				ComicIdentifier = Guid.Parse(input: "8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"),
				Name = "Sci-Fi Comic",
				Description = "This comic follows the adventures of a group of sci-fi heroes in a universe of advanced technology and alien civilizations.",
				PublishDate = new(year: 2016, month: 3, day: 1),
				LatestChapter = 13
			},
			new()
			{
				ComicIdentifier = Guid.Parse(input: "5d34237a-f44c-4f3f-8495-2b36047e034e"),
				Name = "Historical Comic",
				Description = "This comic follows the adventures of a group of historical heroes in a universe of real-world events and historical figures.",
				PublishDate = new(year: 2017, month: 4, day: 1),
				LatestChapter = 19
			},
			new()
			{
				ComicIdentifier = Guid.Parse(input: "b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"),
				Name = "Romantic Comic",
				Description = "This comic follows the adventures of a group of romantic heroes in a universe of love and relationships.",
				PublishDate = new(year: 2018, month: 4, day: 22),
				LatestChapter = 33
			}
		};

		builder.HasData(data: comics);
	}
}
