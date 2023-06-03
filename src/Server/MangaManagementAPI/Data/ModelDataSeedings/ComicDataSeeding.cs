using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.IO;

namespace MangaManagementAPI.Data.ModelDataSeedings;

public class ComicDataSeeding : IEntityTypeConfiguration<Comic>
{
	public void Configure(EntityTypeBuilder<Comic> builder)
	{
		ICollection<Comic> comics = new List<Comic>()
		{
			new()
			{
				ComicIdentifier = new(g: "4dfe12e0-cb8a-4282-8e74-3b1e8053f787"),
				Name = "atadakishta",
				Description = "This comic follows the adventures of a group of superheroes in a universe of superpowers and evil villains.",
				PublishDate = new(year: 2014, month: 1, day: 1),
				LatestChapter = 40,
				Avatar = Path.Combine("C:", "Users", "USER", "Downloads", "pic1.jpg")
			},
			new()
			{
				ComicIdentifier = new(g: "aadadaf7-fc21-4559-a53c-f97eb1ba583f"),
				Name = "bouken-sha no tabi",
				Description = "This comic follows the adventures of a group of fantasy heroes in a universe of magic and mysticism.",
				PublishDate = new(year: 2015, month: 2, day: 1),
				LatestChapter = 8,
				Avatar = Path.Combine("C:", "Users", "USER", "Downloads", "pic1.jpg")
			},
			new()
			{
				ComicIdentifier = new(g: "8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"),
				Name = "eiyu no chi",
				Description = "This comic follows the adventures of a group of sci-fi heroes in a universe of advanced technology and alien civilizations.",
				PublishDate = new(year: 2016, month: 3, day: 1),
				LatestChapter = 13,
				Avatar = Path.Combine("C:", "Users", "USER", "Downloads", "pic1.jpg")
			},
			new()
			{
				ComicIdentifier = new(g: "5d34237a-f44c-4f3f-8495-2b36047e034e"),
				Name = "eikan no tatakai",
				Description = "This comic follows the adventures of a group of historical heroes in a universe of real-world events and historical figures.",
				PublishDate = new(year: 2017, month: 4, day: 1),
				LatestChapter = 19,
				Avatar = Path.Combine("C:", "Users", "USER", "Downloads", "pic1.jpg")
			},
			new()
			{
				ComicIdentifier = new(g: "b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"),
				Name = "shichiryu no himitsu",
				Description = "This comic follows the adventures of a group of romantic heroes in a universe of love and relationships.",
				PublishDate = new(year: 2018, month: 4, day: 22),
				LatestChapter = 33,
				Avatar = Path.Combine("C:", "Users", "USER", "Downloads", "pic1.jpg")
			}
		};

		builder.HasData(data: comics);
	}
}
