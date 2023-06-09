using Helper.DefinedEnums;
using System;
using System.Collections.Generic;

namespace Entity;

public class UserEntity
{
    public Guid UserIdentifier { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public string UserFullName { get; set; }

    public DefinedGender UserGender { get; set; }

    public DateOnly UserBirthday { get; set; }

    public string UserPhoneNumber { get; set; }

    public string UserEmail { get; set; }

    public int UserAccountBalance { get; set; }

    public string UserAvatar { get; set; }

    public PublisherEntity PublisherEntity { get; set; }

    public ICollection<TransactionsHistoryEntity> TransactionHistoryEntities { get; set; } = new List<TransactionsHistoryEntity>();

    public ICollection<ComicSavingEntity> ComicSavingEntities { get; set; } = new List<ComicSavingEntity>();

    public ICollection<ReadingHistoryEntity> ReadingHistorieEntities { get; set; } = new List<ReadingHistoryEntity>();

    public ICollection<ReviewComicEntity> ReviewComicEntities { get; set; } = new List<ReviewComicEntity>();

    public ICollection<ReviewChapterEntity> ReviewChapterEntities { get; set; } = new List<ReviewChapterEntity>();

    public ICollection<BuyingHistoryEntity> BuyingHistorieEntities { get; set; } = new List<BuyingHistoryEntity>();
}
