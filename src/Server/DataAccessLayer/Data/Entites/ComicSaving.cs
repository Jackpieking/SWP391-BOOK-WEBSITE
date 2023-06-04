using System;

namespace MangaManagementAPI.Data.Entites;

public class ComicSaving
{
	public Guid UserIdentifier { get; set; }

	public Guid ComicIdentifier { get; set; }

	public DateTime SavingTime { get; set; }

	public UserInfo UserInfo { get; set; }

	public Comic Comic { get; set; }
}