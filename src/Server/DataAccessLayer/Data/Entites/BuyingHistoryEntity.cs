using System;

namespace DataAccessLayer.Data.Entites;

public class BuyingHistoryEntity
{
    public Guid UserIdentifer { get; set; }

    public Guid ChapterIdentifer { get; set; }

    public DateTime Date { get; set; }

    public UserInfoEntity UserInfo { get; set; }

    public ChapterEntity Chapter { get; set; }
}
