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

    public DateOnly ComicPublishedDate { get; set; }

    public string ComicStatus { get; set; }

    public PublisherEntity PublisherEntity { get; set; }

    public IEnumerable<ReviewComicEntity> ReviewComicEntities { get; set; } = new List<ReviewComicEntity>();

    public IEnumerable<ComicSavingEntity> ComicSavingEntities { get; set; } = new List<ComicSavingEntity>();

    public IEnumerable<ChapterEntity> ChapterEntities { get; set; } = new List<ChapterEntity>();

    public IEnumerable<ComicCategoryEntity> ComicCategoryEntities { get; set; } = new List<ComicCategoryEntity>();

    public IEnumerable<ComicLikeEntity> ComicLikeEntities { get; set; } = new List<ComicLikeEntity>();
}