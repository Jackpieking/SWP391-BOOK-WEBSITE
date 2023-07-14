using System;
using System.Collections.Generic;

namespace NewClient.Models;

public class DisplayAllChapterImagesOfAChapterModel
{
    public string ComicName { get; set; }

    public string ChapterNumber { get; set; }

    public Guid ChapterIdentifier { get; set; }

    public Guid FirstChapterIdentifier { get; set; }

    public Guid LastChapterIdentifier { get; set; }

    public Guid NextChapterIdentifier { get; set; }

    public Guid PreviousChapterIdentifier { get; set; }

    public IEnumerable<ChapterImageDto> ChapterImages { get; set; }

    public IEnumerable<ReviewChapterDto> ChapterReviews { get; set; }

    public class ChapterImageDto
    {
        public string ImageURL { get; set; }
    }

    public class ReviewChapterDto
    {
        public string Username { get; set; }

        public string UserAvatar { get; set; }

        public string ChapterComment { get; set; }

        public short ChapterRatingStar { get; set; }

        public DateTime ReviewTime { get; set; }
    }
}
