using System;

namespace MangaManagementAPI
{
    public class MangaSaving
    {
        public int ID { get; set; }

        public Guid UserIdentifier { get; set; }

        public Guid ComicIdentifier { get; set; }

        public Guid ChapterIdentifier { get; set; }
    }
}