using System;

namespace MangaManagementAPI
{
    public class ReviewChapter
    {
        public int ID { get; set; }

        public int RatingStart { get; set; }

        public string Comment { get; set; }

        public DateTime Time { get; set; }

        public Guid UserIdentifier { get; set; }

        public Guid ChapterIdentifier { get; set; }
    }
}