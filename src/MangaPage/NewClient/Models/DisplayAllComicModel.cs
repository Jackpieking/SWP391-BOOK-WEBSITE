using System;

namespace NewClient.Models;

public class DisplayAllComicModel
{
    public Guid ComicIdentifier { get; set; }

    public string ComicName { get; set; }

    public DateOnly ComicPublishDate { get; set; }

    public string ComicLatestChapter { get; set; }

    public string ComicAvatar { get; set; }

    public int ReadersCounts { get; set; }

    public int ReviewCounts { get; set; }

    public DateTime LastestComicReviewDate { get; set; }
}