using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models;

public class ComicModel
{
	public Guid ComicIdentifier { get; set; }

	public string Name { get; set; }

	public string Description { get; set; }

	public string Avatar { get; set; }

	public DateOnly PublishDate { get; set; }

	public double LatestChapter { get; set; }

	public ICollection<ReviewComicModel> ReviewComics { get; set; } = new List<ReviewComicModel>();

	public ICollection<ComicSavingModel> ComicSavings { get; set; } = new List<ComicSavingModel>();

	public ICollection<ChapterModel> Chapters { get; set; } = new List<ChapterModel>();

	public ICollection<ComicCategoryModel> ComicCategories { get; set; } = new List<ComicCategoryModel>();
}