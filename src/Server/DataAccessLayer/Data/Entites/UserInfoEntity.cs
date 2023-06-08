using Helper.DefinedEnums;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Data.Entites;

public class UserInfoEntity
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

    public PublisherEntity Publisher { get; set; }

    public ICollection<TransactionsHistoryEntity> TransactionHistories { get; set; } = new List<TransactionsHistoryEntity>();

    public ICollection<ComicSavingEntity> ComicSavings { get; set; } = new List<ComicSavingEntity>();

    public ICollection<ReadingHistoryEntity> ReadingHistories { get; set; } = new List<ReadingHistoryEntity>();

    public ICollection<ReviewComicEntity> ReviewComics { get; set; } = new List<ReviewComicEntity>();

    public ICollection<ReviewChapterEntity> ReviewChapters { get; set; } = new List<ReviewChapterEntity>();

    public ICollection<BuyingHistoryEntity> BuyingHistories { get; set; } = new List<BuyingHistoryEntity>();
}
