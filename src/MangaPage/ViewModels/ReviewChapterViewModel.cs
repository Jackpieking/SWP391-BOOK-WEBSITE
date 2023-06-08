using System;

namespace ViewModels;

public class ReviewChapterViewModel
{
    public Guid UserIdentifier { get; set; }

    public Guid ChapterIdentifier { get; set; }

    public short RatingStar { get; set; }

    public string Comment { get; set; }

    public DateTime ReviewTime { get; set; }

    public UserInfoViewModel UserInfo { get; set; }

    public ChapterViewModel Chapter { get; set; }
}