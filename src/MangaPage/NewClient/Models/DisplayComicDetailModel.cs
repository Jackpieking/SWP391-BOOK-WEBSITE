using System;
using System.Collections.Generic;

namespace NewClient.Models;

public class DisplayComicDetailModel
{
    public string ComicName { get; set; }

    public string ComicDescription { get; set; }

    public string ComicAvatar { get; set; }

    public string PublisherName { get; set; }

    public DateOnly ComicPublishedDate { get; set; }

    public int ReaderCounts { get; set; }

    public ICollection<ReviewComicDto> ReviewComics { get; set; }

    public ICollection<string> CategoryNames { get; set; }

    public ICollection<ChapterDto> ComicChapters { get; set; }

    public class ReviewComicDto
    {
        public short ComicRatingStar { get; set; }

        public string ComicComment { get; set; }

        public DateTime ReviewTime { get; set; }

        public string Username { get; set; }

        public string UserAvatar { get; set; }
    }

    public class ChapterDto
    {
        public Guid ChapterIdentifier { get; set; }

        public double ChapterNumber { get; set; }

        public int ChapterUnlockPrice { get; set; }

        public DateOnly AddedDate { get; set; }
    }
}
