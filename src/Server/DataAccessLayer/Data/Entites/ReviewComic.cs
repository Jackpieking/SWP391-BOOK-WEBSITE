using System;

namespace MangaManagementAPI.Data.Entites;

public class ReviewComic
{
	public Guid UserIdentifier { get; set; }

	public Guid ComicIdentifier { get; set; }

	public short RatingStar { get; set; }

	public string Comment { get; set; }

	public DateTime ReviewTime { get; set; }

	public UserInfo UserInfo { get; set; }

	public Comic Comic { get; set; }
}