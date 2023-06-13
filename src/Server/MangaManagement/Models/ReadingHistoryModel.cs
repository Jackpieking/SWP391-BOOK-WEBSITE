using System;

namespace Model;

public class ReadingHistoryModel
{
    public Guid UserIdentifier { get; set; }

    public Guid ChapterIdentifier { get; set; }

    public DateTime LastReadingTime { get; set; }

    public UserModel UserModel { get; set; }

    public ChapterModel ChapterModel { get; set; }
}