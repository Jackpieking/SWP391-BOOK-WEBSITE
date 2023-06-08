using System;
using System.Collections.Generic;

namespace DataAccessLayer.Data.Entites;

public class ComicEntity
{
    public Guid ComicIdentifier { get; set; }

    public Guid PublisherIdentifier { get; set; }

    public PublisherEntity Publisher { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Avatar { get; set; }

    public DateOnly PublishDate { get; set; }

    public double LatestChapter { get; set; }

    public ICollection<ReviewComicEntity> ReviewComics { get; set; } = new List<ReviewComicEntity>();

    public ICollection<ComicSavingEntity> ComicSavings { get; set; } = new List<ComicSavingEntity>();

    public ICollection<ChapterEntity> Chapters { get; set; } = new List<ChapterEntity>();

    public ICollection<ComicCategoryEntity> ComicCategories { get; set; } = new List<ComicCategoryEntity>();
}