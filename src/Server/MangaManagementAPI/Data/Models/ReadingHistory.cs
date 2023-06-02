using System;

namespace MangaManagementAPI.Data.Models;

public class ReadingHistory
{
	public Guid UserIdentifier { get; set; }

	public Guid ChapterIdentifier { get; set; }

	public DateTime LastReadingTime { get; set; }

	public UserInfo UserInfo { get; set; } = new();

	public Chapter Chapter { get; set; } = new();
}