using System;
using System.Collections.Generic;

namespace Entity;

public class ComicEntity
{
    public Guid ComicIdentifier { get; set; }

    public Guid PublisherIdentifier { get; set; }

    public string ComicName { get; set; }

    public string ComicDescription { get; set; }

    public string ComicAvatar { get; set; }

    public DateOnly ComicPublishDate { get; set; }

    public double ComicLatestChapter { get; set; }

    public PublisherEntity PublisherEntity { get; set; }

    public ICollection<ReviewComicEntity> ReviewComicEntities { get; set; } = new List<ReviewComicEntity>();

    public ICollection<ComicSavingEntity> ComicSavingEntities { get; set; } = new List<ComicSavingEntity>();

    public ICollection<ChapterEntity> ChapterEntities { get; set; } = new List<ChapterEntity>();

    public ICollection<ComicCategoryEntity> ComicCategoryEntities { get; set; } = new List<ComicCategoryEntity>();
}