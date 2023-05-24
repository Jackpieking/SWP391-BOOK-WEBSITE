using MangaManagementAPI.Helpers;
using System;

namespace MangaManagementAPI.Data.Models;

internal class LoginAccount
{
	public int ID { get; set; }

	public string UserName { get; set; } = string.Empty;

	public string Password { get; set; } = string.Empty;

	public Role Role { get; set; }

	public Guid UserIdentifier { get; set; }

	public UserAccess UserAccess { get; set; }
}
