using System;

namespace MangaManagementAPI.Data.Entites;

public class ReadingHistory
{
	public Guid UserIdentifier { get; set; }

	public Guid ChapterIdentifier { get; set; }

	public DateTime LastReadingTime { get; set; }

	public UserInfo UserInfo { get; set; }

	public Chapter Chapter { get; set; }
}