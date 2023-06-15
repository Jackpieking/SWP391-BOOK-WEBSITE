using System;
using System.Collections.Generic;

namespace MangaCrawlerApi.Data.Models;

public class Comic
{
	public string ComicName { get; set; }

	public string ComicDescription { get; set; }

	public DateOnly ComicPublishedDate { get; set; }

	public string ComicStatus { get; set; }

	public string ComicAvatarUrl { get; set; }

	public IList<Category> ComicCategories { get; set; }

	public IList<Chapter> ComicChapters { get; set; }
}
