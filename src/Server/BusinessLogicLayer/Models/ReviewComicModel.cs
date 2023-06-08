using System;

namespace DataAccessLayer.Models;

public class ReviewComicModel
{
	public Guid UserIdentifier { get; set; }

	public Guid ComicIdentifier { get; set; }

	public short RatingStar { get; set; }

	public string Comment { get; set; }

	public DateTime ReviewTime { get; set; }

	public UserInfoModel UserInfo { get; set; }

	public ComicModel Comic { get; set; }
}