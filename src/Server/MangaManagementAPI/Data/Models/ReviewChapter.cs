using System;

namespace MangaManagementAPI.Data.Models;

public class ReviewChapter
{
	public Guid UserIdentifier { get; set; }

	public Guid ChapterIdentifier { get; set; }

	public short RatingStar { get; set; }

	public string Comment { get; set; }

	public DateTime ReviewTime { get; set; }

	public UserInfo UserInfo { get; set; }

	public Chapter Chapter { get; set; }
}