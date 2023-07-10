using System;

namespace Entity;

public class ReadingHistoryEntity
{
    public Guid UserIdentifier { get; set; }

    public Guid ChapterIdentifier { get; set; }

    public DateTime LastReadingTime { get; set; }

    public virtual UserEntity UserEntity { get; set; }

    public virtual ChapterEntity ChapterEntity { get; set; }
}