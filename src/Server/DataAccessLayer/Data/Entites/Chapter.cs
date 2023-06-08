using DataAccessLayer.Data.Entites;
using System;
using System.Collections.Generic;

namespace MangaManagementAPI.Data.Entites;

public class Chapter
{
    public Guid ChapterIdentifier { get; set; }

    public double ChapterNumber { get; set; }

    public int UnlockPrice { get; set; }

    public Guid ComicIdentifier { get; set; }

    public Comic Comic { get; set; }

    public ICollection<ReviewChapter> ReviewChapters { get; set; } = new List<ReviewChapter>();

    public ICollection<ReadingHistory> ReadingHistories { get; set; } = new List<ReadingHistory>();

    public ICollection<ChapterImage> ChapterImages { get; set; } = new List<ChapterImage>();

    public ICollection<BuyingHistory> BuyingHistories { get; set; } = new List<BuyingHistory>();
}