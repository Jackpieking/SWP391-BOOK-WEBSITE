using Helper.DefinedEnum;
using System;
using System.Collections.Generic;

namespace ViewModels;

public class UserInfoViewModel
{
    public Guid UserIdentifier { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public string FullName { get; set; }

    public DefinedGender Gender { get; set; }

    public DateOnly BirthDay { get; set; }

    public string PhoneNumber { get; set; }

    public string Email { get; set; }

    public int AccountBalance { get; set; }

    public string Avatar { get; set; }

    public ICollection<TransactionsHistoryViewModel> TransactionHistories { get; set; } = new List<TransactionsHistoryViewModel>();

    public ICollection<ComicSavingViewModel> ComicSavings { get; set; } = new List<ComicSavingViewModel>();

    public ICollection<ReadingHistoryViewModel> ReadingHistories { get; set; } = new List<ReadingHistoryViewModel>();

    public ICollection<ReviewComicViewModel> ReviewComics { get; set; } = new List<ReviewComicViewModel>();

    public ICollection<ReviewChapterViewModel> ReviewChapters { get; set; } = new List<ReviewChapterViewModel>();
}
