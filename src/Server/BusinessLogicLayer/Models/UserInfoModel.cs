using Helper.DefinedEnums;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models;

public class UserInfoModel
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

	public ICollection<TransactionsHistoryModel> TransactionHistories { get; set; } = new List<TransactionsHistoryModel>();

	public ICollection<ComicSavingModel> ComicSavings { get; set; } = new List<ComicSavingModel>();

	public ICollection<ReadingHistoryModel> ReadingHistories { get; set; } = new List<ReadingHistoryModel>();

	public ICollection<ReviewComicModel> ReviewComics { get; set; } = new List<ReviewComicModel>();

	public ICollection<ReviewChapterModel> ReviewChapters { get; set; } = new List<ReviewChapterModel>();
}
