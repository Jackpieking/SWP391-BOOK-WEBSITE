using System;

namespace MangaManagementAPI.Data.Models;

public class ReviewComic
{
	public Guid UserIdentifier { get; set; }

	public Guid ComicIdentifier { get; set; }

	public short RatingStar { get; set; }

	public string Comment { get; set; }

	public DateTime ReviewTime { get; set; }

	public UserInfo UserInfo { get; set; } = new();

	public Comic Comic { get; set; } = new();
}