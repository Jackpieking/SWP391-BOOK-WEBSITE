using System;
using System.Collections.Generic;

namespace Model;

public class ChapterModel
{
    public Guid ChapterIdentifier { get; set; }

    public double ChapterNumber { get; set; }

    public int ChapterUnlockPrice { get; set; }

    public Guid ComicIdentifier { get; set; }

    public ComicModel ComicModel { get; set; }

    public ICollection<ReviewChapterModel> ReviewChapterModels { get; set; }

    public ICollection<ReadingHistoryModel> ReadingHistoryModels { get; set; }

    public ICollection<ChapterImageModel> ChapterImageModels { get; set; }

    public ICollection<BuyingHistoryModel> BuyingHistoryModels { get; set; }
}