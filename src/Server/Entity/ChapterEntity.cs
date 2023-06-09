using System;
using System.Collections.Generic;

namespace Entity;

public class ChapterEntity
{
    public Guid ChapterIdentifier { get; set; }

    public double ChapterNumber { get; set; }

    public int ChapterUnlockPrice { get; set; }

    public Guid ComicIdentifier { get; set; }

    public ComicEntity ComicEntity { get; set; }

    public ICollection<ReviewChapterEntity> ReviewChapterEntities { get; set; } = new List<ReviewChapterEntity>();

    public ICollection<ReadingHistoryEntity> ReadingHistoryEntities { get; set; } = new List<ReadingHistoryEntity>();

    public ICollection<ChapterImageEntity> ChapterImageEntities { get; set; } = new List<ChapterImageEntity>();

    public ICollection<BuyingHistoryEntity> BuyingHistoryEntities { get; set; } = new List<BuyingHistoryEntity>();
}