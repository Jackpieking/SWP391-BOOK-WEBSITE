using System;

namespace DataAccessLayer.Data.Entites;

public class ReadingHistoryEntity
{
    public Guid UserIdentifier { get; set; }

    public Guid ChapterIdentifier { get; set; }

    public DateTime LastReadingTime { get; set; }

    public UserInfoEntity UserInfo { get; set; }

    public ChapterEntity Chapter { get; set; }
}