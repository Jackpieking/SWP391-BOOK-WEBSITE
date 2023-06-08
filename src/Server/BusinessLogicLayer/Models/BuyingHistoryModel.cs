using DataAccessLayer.Models;
using System;

namespace DataAccessLayer.Data.Entites;

public class BuyingHistoryModel
{
    public Guid UserIdentifer { get; set; }

    public Guid ChapterIdentifer { get; set; }

    public DateTime Date { get; set; }

    public UserInfoModel UserInfo { get; set; }

    public ChapterModel Chapter { get; set; }
}
