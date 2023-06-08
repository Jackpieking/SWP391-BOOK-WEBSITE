using System;
using System.Collections.Generic;

namespace ViewModels;

public class ChapterViewModel
{
    public Guid ChapterIdentifier { get; set; }

    public double ChapterNumber { get; set; }

    public int UnlockPrice { get; set; }

    public Guid ComicIdentifier { get; set; }

    public ComicViewModel Comic { get; set; }

    public ICollection<ReviewChapterViewModel> ReviewChapters { get; set; } = new List<ReviewChapterViewModel>();

    public ICollection<ReadingHistoryViewModel> ReadingHistories { get; set; } = new List<ReadingHistoryViewModel>();

    public ICollection<ChapterImageViewModel> ChapterImages { get; set; } = new List<ChapterImageViewModel>();
}