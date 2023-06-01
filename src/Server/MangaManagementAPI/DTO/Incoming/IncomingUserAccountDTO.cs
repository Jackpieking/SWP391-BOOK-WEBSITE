﻿using System.ComponentModel.DataAnnotations;

namespace MangaManagementAPI.DTO.Incoming;

public class IncomingUserAccountDTO
{
	[StringLength(maximumLength: 50)]
	[Required]
	public string UserName { get; set; }

	[StringLength(maximumLength: 50)]
	[Required]
	public string Password { get; set; }
}