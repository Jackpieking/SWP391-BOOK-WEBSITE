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

    public IEnumerable<TransactionsHistoryEntity> TransactionHistoryEntities { get; set; } = new List<TransactionsHistoryEntity>();

    public IEnumerable<ComicSavingEntity> ComicSavingEntities { get; set; } = new List<ComicSavingEntity>();

    public IEnumerable<ReadingHistoryEntity> ReadingHistorieEntities { get; set; } = new List<ReadingHistoryEntity>();

    public IEnumerable<ReviewComicEntity> ReviewComicEntities { get; set; } = new List<ReviewComicEntity>();

    public IEnumerable<ReviewChapterEntity> ReviewChapterEntities { get; set; } = new List<ReviewChapterEntity>();

    public IEnumerable<BuyingHistoryEntity> BuyingHistorieEntities { get; set; } = new List<BuyingHistoryEntity>();

    public IEnumerable<ComicLikeEntity> ComicLikeEntities { get; set; } = new List<ComicLikeEntity>();
}
