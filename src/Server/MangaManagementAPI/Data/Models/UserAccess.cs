﻿using MangaManagementAPI.Helpers;
using System;

namespace MangaManagementAPI.Data.Models;

public class UserAccess
{
	public int ID { get; set; }

	public string FullName { get; set; } = string.Empty;

	public Gender? Gender { get; set; }

	public DateOnly BirthDay { get; set; }

	public string Email { get; set; } = string.Empty;

	public int AccountBalance { get; set; }

	public string Avatar { get; set; } //defaul avatar

	public Guid UserIdentifier { get; set; }

	public LoginAccount LoginAccount { get; set; }
}
