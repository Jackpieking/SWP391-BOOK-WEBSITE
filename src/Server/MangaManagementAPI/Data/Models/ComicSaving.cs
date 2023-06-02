using System;

namespace MangaManagementAPI.Data.Models;

public class ComicSaving
{
	public Guid UserIdentifier { get; set; }

	public Guid ComicIdentifier { get; set; }

	public DateTime SavingTime { get; set; }

	public UserInfo UserInfo { get; set; } = new();

	public Comic Comic { get; set; } = new();
}