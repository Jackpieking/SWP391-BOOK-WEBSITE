using System;

namespace MangaCrawlerApi.Data.Models;

public class Category
{
	public Guid CategoryIdentifier { get; set; }

	public string CategoryName { get; set; }

	public string CategoryDescription { get; set; }
}
