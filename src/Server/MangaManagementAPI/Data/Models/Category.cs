using System;

namespace MangaManagementAPI
{
    public class Category
    {
        public int ID {get; set;}

        public string Name {get; set;}

        public string Description {get; set;}

        public Guid CategoryIdentifier {get; set;}
    }
}