using System;

namespace MangaManagementAPI
{
    public class ReadingHistory
    {
        public int ID {get; set;}
        
        public DateTime ReadOn {get; set;}

        public Guid UserIdentifier {get; set;}

        public Guid ComicIdentifier {get; set;}

        public Guid ChapterIdentifier {get; set;}
    }
}