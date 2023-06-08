using System;

namespace ViewModels;

public class ReviewComicViewModel
{
    public Guid UserIdentifier { get; set; }

    public Guid ComicIdentifier { get; set; }

    public short RatingStar { get; set; }

    public string Comment { get; set; }

    public DateTime ReviewTime { get; set; }

    public UserInfoViewModel UserInfo { get; set; }

    public ComicViewModel Comic { get; set; }
}