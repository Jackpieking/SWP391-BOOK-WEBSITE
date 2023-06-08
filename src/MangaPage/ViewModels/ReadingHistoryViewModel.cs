using System;

namespace ViewModels;

public class ReadingHistoryViewModel
{
    public Guid UserIdentifier { get; set; }

    public Guid ChapterIdentifier { get; set; }

    public DateTime LastReadingTime { get; set; }

    public UserInfoViewModel UserInfo { get; set; }

    public ChapterViewModel Chapter { get; set; }
}