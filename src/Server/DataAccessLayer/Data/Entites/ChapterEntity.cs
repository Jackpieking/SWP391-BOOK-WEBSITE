using System;
using System.Collections.Generic;

namespace DataAccessLayer.Data.Entites;

public class ChapterEntity
{
    public Guid ChapterIdentifier { get; set; }

    public double ChapterNumber { get; set; }

    public int UnlockPrice { get; set; }

    public Guid ComicIdentifier { get; set; }

    public ComicEntity Comic { get; set; }

    public ICollection<ReviewChapterEntity> ReviewChapters { get; set; } = new List<ReviewChapterEntity>();

    public ICollection<ReadingHistoryEntity> ReadingHistories { get; set; } = new List<ReadingHistoryEntity>();

    public ICollection<ChapterImageEntity> ChapterImages { get; set; } = new List<ChapterImageEntity>();

    public ICollection<BuyingHistoryEntity> BuyingHistories { get; set; } = new List<BuyingHistoryEntity>();
}