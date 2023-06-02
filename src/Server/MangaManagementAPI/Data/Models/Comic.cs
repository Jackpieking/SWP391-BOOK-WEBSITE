using System;
using System.Collections.Generic;

namespace MangaManagementAPI.Data.Models;

public class Comic
{
	public Guid ComicIdentifier { get; set; }

	public string Name { get; set; } = string.Empty;

	public string Description { get; set; } = string.Empty;

	public string Avatar { get; set; } = string.Empty;

	public DateOnly PublishDate { get; set; } = DateOnly.Parse(s: DateTime.Now.ToShortDateString());

	public double LatestChapter { get; set; }

	public ICollection<ReviewComic> ReviewComics { get; set; } = new List<ReviewComic>();

	public ICollection<ComicSaving> ComicSavings { get; set; } = new List<ComicSaving>();

	public ICollection<Chapter> Chapters { get; set; } = new List<Chapter>();

	public ICollection<ComicCategory> ComicCategories { get; set; } = new List<ComicCategory>();
}