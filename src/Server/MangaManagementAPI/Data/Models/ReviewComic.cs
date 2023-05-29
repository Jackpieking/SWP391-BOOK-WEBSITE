using System;

namespace MangaManagementAPI
{
    public class ReviewComic
    {
        public int ID { get; set; }

        public int RatingStar { get; set; }

        public string Comment { get; set; }

        public DateTime Time { get; set; }

        public Guid UserIdentifier { get; set; }

        public Guid ComicIdentifier { get; set; }
    }
}