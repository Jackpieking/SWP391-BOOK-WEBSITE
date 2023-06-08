using MangaManagementAPI.Data.Entites;
using System;

namespace DataAccessLayer.Data.Entites;

public class BuyingHistory
{
    public Guid UserIdentifer { get; set; }

    public Guid ChapterIdentifer { get; set; }

    public DateTime Date { get; set; }

    public UserInfo UserInfo { get; set; }

    public Chapter Chapter { get; set; }
}
