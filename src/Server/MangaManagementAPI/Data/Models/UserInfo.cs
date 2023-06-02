using MangaManagementAPI.Helpers;
using System;
using System.Collections.Generic;

namespace MangaManagementAPI.Data.Models;

public class UserInfo
{
	public Guid UserIdentifier { get; set; }

	public string UserName { get; set; }

	public string Password { get; set; }

	public string FullName { get; set; }

	public DefinedGender? Gender { get; set; }

	public DateOnly BirthDay { get; set; }

	public string PhoneNumber { get; set; }

	public string Email { get; set; }

	public int AccountBalance { get; set; }

	public string Avatar { get; set; }

	public ICollection<TransactionsHistory> TransactionHistories { get; set; } = new List<TransactionsHistory>();

	public ICollection<ComicSaving> ComicSavings { get; set; } = new List<ComicSaving>();

	public ICollection<ReadingHistory> ReadingHistories { get; set; } = new List<ReadingHistory>();

	public ICollection<ReviewComic> ReviewComics { get; set; } = new List<ReviewComic>();

	public ICollection<ReviewChapter> ReviewChapters { get; set; } = new List<ReviewChapter>();
}
