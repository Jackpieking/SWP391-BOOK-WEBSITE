using System;

namespace Model;

public class BuyingHistoryModel
{
    public Guid UserIdentifier { get; set; }

    public Guid ChapterIdentifier { get; set; }

    public DateTime BuyingDate { get; set; }

    public UserModel UserModel { get; set; }

    public ChapterModel ChapterModel { get; set; }
}
