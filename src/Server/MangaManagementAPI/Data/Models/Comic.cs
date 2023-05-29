using System;

namespace MangaManagementAPI
{
    public class Comic
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int LatestChapter { get; set; } // Consider change to double cuz some comics have chaper 14.5

        public string Avatar { get; set; }

        public DateOnly PublishDate { get; set; }

        public Guid ComicIdentifier { get; set; }

        public Guid PubliserIdentifier { get; set; }
    }
}