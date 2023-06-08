using System;

namespace DataAccessLayer.Models;

public class ComicSavingModel
{
	public Guid UserIdentifier { get; set; }

	public Guid ComicIdentifier { get; set; }

	public DateTime SavingTime { get; set; }

	public UserInfoModel UserInfo { get; set; }

	public ComicModel Comic { get; set; }
}