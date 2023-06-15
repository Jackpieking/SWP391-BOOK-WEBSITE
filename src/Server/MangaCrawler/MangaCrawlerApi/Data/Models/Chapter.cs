using System;
using System.Collections.Generic;

namespace MangaCrawlerApi.Data.Models;

public class Chapter
{
	public string ChapterNumber { get; set; }

	public int ChapterUnlockPrice { get; set; }

	public DateOnly AddedDate { get; set; }

	public string ChapterUrl { get; set; }

	public IList<ChapterImage> ChapterImages { get; set; }
}
