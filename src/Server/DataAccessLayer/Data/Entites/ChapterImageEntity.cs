using System;

namespace DataAccessLayer.Data.Entites;

public class ChapterImageEntity
{
    public Guid ImageIdentifier { get; set; }

    public short ImageNumber { get; set; }

    public string ImageURL { get; set; }

    public Guid ChapterIdentifier { get; set; }

    public ChapterEntity Chapter { get; set; }
}