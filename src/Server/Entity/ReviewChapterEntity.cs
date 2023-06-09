using System;

namespace Entity;

public class ReviewChapterEntity
{
    public Guid UserIdentifier { get; set; }

    public Guid ChapterIdentifier { get; set; }

    public short ChapterRatingStar { get; set; }

    public string ChapterComment { get; set; }

    public DateTime ReviewTime { get; set; }

    public UserEntity UserEntity { get; set; }

    public ChapterEntity ChapterEntity { get; set; }
}