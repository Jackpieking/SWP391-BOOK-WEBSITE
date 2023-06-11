using System;

namespace NewClient.Models;

public class ComicModel
{
    public Guid ComicIdentifier { get; set; }

    public string ComicName { get; set; }

    public DateOnly ComicPublishDate { get; set; }

    public double ComicLatestChapter { get; set; }

    public string ComicAvatar { get; set; }

    public int NumberOfReaderHasRead { get; set; }

    public int ReviewCount { get; set; }

    public DateTime LastestComicReviewDate { get; set; }
}