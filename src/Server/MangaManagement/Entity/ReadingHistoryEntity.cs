using System;

namespace Entity;

public class ReadingHistoryEntity
{
    public Guid UserIdentifier { get; set; }

    public Guid ChapterIdentifier { get; set; }

    public DateTime LastReadingTime { get; set; }

    public UserEntity UserEntity { get; set; }

    public ChapterEntity ChapterEntity { get; set; }
}