using DataAccessLayer.Data.Entites;
using System;
using System.Collections.Generic;

namespace MangaManagementAPI.Data.Entites;

public class Comic
{
    public Guid ComicIdentifier { get; set; }

    public Guid PublisherIdentifier { get; set; }

    public Publisher Publisher { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Avatar { get; set; }

    public DateOnly PublishDate { get; set; }

    public double LatestChapter { get; set; }

    public ICollection<ReviewComic> ReviewComics { get; set; } = new List<ReviewComic>();

    public ICollection<ComicSaving> ComicSavings { get; set; } = new List<ComicSaving>();

    public ICollection<Chapter> Chapters { get; set; } = new List<Chapter>();

    public ICollection<ComicCategory> ComicCategories { get; set; } = new List<ComicCategory>();
}