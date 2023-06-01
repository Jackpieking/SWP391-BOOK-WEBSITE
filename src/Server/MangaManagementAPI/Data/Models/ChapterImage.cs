using System;

namespace MangaManagementAPI
{
    public class ChapterImage
    {
        public int ID {get; set;}

        public int ImageNum {get; set;}

        public string ImageURL {get; set;}

        public Guid ChapterIdentifier {get; set;}

    }
}