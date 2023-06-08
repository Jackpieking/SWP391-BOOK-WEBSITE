using System;

namespace DataAccessLayer.Models;

public class ReadingHistoryModel
{
	public Guid UserIdentifier { get; set; }

	public Guid ChapterIdentifier { get; set; }

	public DateTime LastReadingTime { get; set; }

	public UserInfoModel UserInfo { get; set; }

	public ChapterModel Chapter { get; set; }
}