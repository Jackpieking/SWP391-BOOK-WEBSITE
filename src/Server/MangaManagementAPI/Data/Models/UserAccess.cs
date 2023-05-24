using MangaManagementAPI.Helpers;
using System;

namespace MangaManagementAPI.Data.Models;

internal class UserAccess
{
	public int ID { get; set; }

	public string FullName { get; set; } = string.Empty;

	public byte Age { get; set; }

	public Gender? Gender { get; set; }

	public DateOnly? BirthDay { get; set; }

	public string PhoneNumber { get; set; } = string.Empty;

	public string Email { get; set; } = string.Empty;

	public int AccountBalance { get; set; }

	public string Avatar { get; set; } = string.Empty;

	public Guid UserIdentifier { get; set; }

	public LoginAccount LoginAccount { get; set; }
}
