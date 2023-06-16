using System;
using System.Collections.Generic;

namespace Model;

public class CrawlChapterModel
{
	public string ChapterNumber { get; set; }

	public int ChapterUnlockPrice { get; set; }

	public DateOnly AddedDate { get; set; }

	public string ChapterUrl { get; set; }

	public IList<CrawlChapterImageModel> CrawlChapterImageModels { get; set; }
}
