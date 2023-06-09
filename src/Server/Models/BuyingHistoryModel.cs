using System;

namespace Model;

public class BuyingHistoryModel
{
    public Guid UserIdentifer { get; set; }

    public Guid ChapterIdentifer { get; set; }

    public DateTime BuyingDate { get; set; }

    public UserModel UserModel { get; set; }

    public ChapterModel ChapterModel { get; set; }
}
