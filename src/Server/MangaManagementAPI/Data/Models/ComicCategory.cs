﻿using System;

namespace MangaManagementAPI.Data.Models;

public class ComicCategory
{
	public Guid CategoryIdentifier { get; set; }

	public Category Category { get; set; } = new();

	public Guid ComicIdentifier { get; set; }

	public Comic Comic { get; set; } = new();
}
