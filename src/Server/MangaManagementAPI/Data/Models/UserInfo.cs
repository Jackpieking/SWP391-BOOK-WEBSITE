﻿using MangaManagementAPI.Helpers;
using System;

namespace MangaManagementAPI;

public class UserInfo
{
	public int ID { get; set; }

	public string UserName { get; set; } = string.Empty;

	public string Password { get; set; } = string.Empty;

	public Role Role { get; set; }

	public string FullName { get; set; } = string.Empty;

	public Gender? Gender { get; set; }

	public DateOnly BirthDay { get; set; }

	public string Email { get; set; } = string.Empty;

	public int AccountBalance { get; set; }

	public string Avatar { get; set; } //defaul avatar

	public Guid UserIdentifier { get; set; }
}
