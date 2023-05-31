using System;

namespace MangaManagementAPI
{
    public class Chapter
    {
        public int ID { get; set; }

        public int ChapterNumber { get; set; }

        public int UnlockPrice { get; set; }

        public Guid ComicIdentifier { get; set; }

        public Guid ChapterIdentifier { get; set; }
    }
}