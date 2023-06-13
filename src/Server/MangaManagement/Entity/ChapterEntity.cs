using System;
using System.Collections.Generic;

namespace Entity;

public class ChapterEntity
{
    public Guid ChapterIdentifier { get; set; }

    public string ChapterNumber { get; set; }

    public int ChapterUnlockPrice { get; set; }

    public DateOnly AddedDate { get; set; }

    public Guid ComicIdentifier { get; set; }

    public ComicEntity ComicEntity { get; set; }

    public IEnumerable<ReviewChapterEntity> ReviewChapterEntities { get; set; } = new List<ReviewChapterEntity>();

    public IEnumerable<ReadingHistoryEntity> ReadingHistoryEntities { get; set; } = new List<ReadingHistoryEntity>();

    public IEnumerable<ChapterImageEntity> ChapterImageEntities { get; set; } = new List<ChapterImageEntity>();

    public IEnumerable<BuyingHistoryEntity> BuyingHistoryEntities { get; set; } = new List<BuyingHistoryEntity>();
}