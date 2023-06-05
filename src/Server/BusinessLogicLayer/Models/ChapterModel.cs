using System;
using System.Collections.Generic;

namespace MangaManagementAPI.Models;

public class ChapterModel
{
	public Guid ChapterIdentifier { get; set; }

	public double ChapterNumber { get; set; }

	public int UnlockPrice { get; set; }

	public Guid ComicIdentifier { get; set; }

	public ComicModel Comic { get; set; }

	public ICollection<ReviewChapterModel> ReviewChapters { get; set; }	= new List<ReviewChapterModel>();

	public ICollection<ReadingHistoryModel> ReadingHistories { get; set; } = new List<ReadingHistoryModel>();

	public ICollection<ChapterImageModel> ChapterImages { get; set; } = new List<ChapterImageModel>();
}