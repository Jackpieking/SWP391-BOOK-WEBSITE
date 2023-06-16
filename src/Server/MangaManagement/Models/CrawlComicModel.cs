using System;
using System.Collections.Generic;

namespace Model;

public class CrawlComicModel
{
	public string ComicName { get; set; }

	public string ComicDescription { get; set; }

	public DateOnly ComicPublishedDate { get; set; }

	public string ComicStatus { get; set; }

	public string ComicAvatarUrl { get; set; }

	public IList<CrawlCategoryModel> CrawlComicCategoryModels { get; set; }

	public IList<CrawlChapterModel> CrawlComicChapterModels { get; set; }
}
