using System;

namespace Entity;

public class ChapterImageEntity
{
    public Guid ImageIdentifier { get; set; }

    public short ImageNumber { get; set; }

    public string ImageURL { get; set; }

    public Guid ChapterIdentifier { get; set; }

    public ChapterEntity ChapterEntity { get; set; }
}