using System;

namespace ViewModels;

public class ChapterImageViewModel
{
    public Guid ImageIdentifier { get; set; }

    public short ImageNumber { get; set; }

    public string ImageURL { get; set; }

    public Guid ChapterIdentifier { get; set; }

    public ChapterViewModel Chapter { get; set; }
}