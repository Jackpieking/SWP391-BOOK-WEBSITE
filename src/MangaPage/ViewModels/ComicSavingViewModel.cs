using System;

namespace ViewModels;

public class ComicSavingViewModel
{
    public Guid UserIdentifier { get; set; }

    public Guid ComicIdentifier { get; set; }

    public DateTime SavingTime { get; set; }

    public UserInfoViewModel UserInfo { get; set; }

    public ComicViewModel Comic { get; set; }
}