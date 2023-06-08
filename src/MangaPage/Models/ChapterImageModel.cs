using System;

namespace Models;

public class ChapterImageModel
{
    public Guid ImageIdentifier { get; set; }

    public short ImageNumber { get; set; }

    public string ImageURL { get; set; }

    public Guid ChapterIdentifier { get; set; }

    public ChapterModel Chapter { get; set; }
}