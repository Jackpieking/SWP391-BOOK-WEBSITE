using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace MangaManagementAPI.Data.ModelDataSeedings;

public class CategoryDataSeeding : IEntityTypeConfiguration<Category>
{
	public void Configure(EntityTypeBuilder<Category> builder)
	{
		ICollection<Category> categories = new List<Category>()
		{
			new()
			{
				CategoryIdentifier = new(g: "414e65b4-1949-48ce-a764-26fb66e95550"),
				Name = "Cooking",
				Description = "A story where a lot of cooking and cooking-related topics are covered. This includes cooking shows, celebrity chefs, restaurants, recipe books, cooking techniques, and other topics related to cooking. For example, some common subcategories are cooking techniques, vegan cooking, baking, and food chemistry."
			},
			new()
			{
				CategoryIdentifier = new(g: "1b9d5460-4c32-4703-b4bd-c52e5fb6e943"),
				Name = "MartialArts",
				Description = "A story where martial arts and martial arts-related topics are covered. This includes stories about martial artists, martial arts tournaments, martial arts academies, and other topics related to martial arts. For example, some common subcategories are martial arts styles, self-defense, and martial arts history. Some anime and manga with this category include 'Kenichi: The Mightiest Disciple' and 'The Karate Kid.'"
			},
			new()
			{
				CategoryIdentifier = new(g: "ad2149ef-ac21-4759-88d8-e586e850e299"),
				Name = "SchoolLife",
				Description = "A story where student life and school-related topics are covered. This includes stories about students, teachers, school activities, school dramas, and other topics related to the school setting. For example, some common subcategories are school life, school romances, school sports, and school clubs. Some manga and anime with this category include 'K-On!' and 'GTO.'"
			},
			new()
			{
				CategoryIdentifier = new(g: "edc6e266-7b95-4723-a420-8e51a78d99bc"),
				Name = "Action",
				Description = "A story where fighting and battling-related topics are covered. This includes stories about heroes, villains, monsters, ninjas, soldiers, aliens, robots, and other topics related to battles and wars. For example, some common subcategories are action adventures, science fiction, and super-hero stories. Some manga and anime with this category include 'Dragon Ball Z' and 'One Piece.'"
			},
			new()
			{
				CategoryIdentifier = new(g: "72522ef6-6633-4519-872b-36bc0675e328"),
				Name = "Sci-fi",
				Description = "A story where science fiction and sci-fi-related topics are covered. This includes stories about futuristic worlds, space travel, aliens, cyborgs, robots, and other topics related to imaginary or futuristic worlds. For example, some common subcategories are sci-fi adventures, science fiction romance, and space operas. Some manga and anime with this category include 'Ghost in the Shell' and 'Cowboy Bebop.'"
			},
			new()
			{
				CategoryIdentifier = new(g: "ddebafec-b0a5-49c6-ac6c-261079080dce"),
				Name = "FullColor",
				Description = "A story where the art is in full color."
			},
			new()
			{
				CategoryIdentifier = new(g: "322dbf35-54aa-416e-b121-42fc20b9d94b"),
				Name = "Horror",
				Description = "A story where horror and horror-related topics are covered. This includes stories about monsters, ghosts, demons, zombies, vampires, and other"
			},
		};

		builder.HasData(data: categories);
	}
}
