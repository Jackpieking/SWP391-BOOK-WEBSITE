using System;

namespace MangaManagementAPI.Models;

public class ReviewChapterModel
{
	public Guid UserIdentifier { get; set; }

	public Guid ChapterIdentifier { get; set; }

	public short RatingStar { get; set; }

	public string Comment { get; set; }

	public DateTime ReviewTime { get; set; }

	public UserInfoModel UserInfo { get; set; }

	public ChapterModel Chapter { get; set; }
}