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

    public virtual PublisherEntity PublisherEntity { get; set; }

    public virtual IEnumerable<TransactionsHistoryEntity> TransactionHistoryEntities { get; set; } = new List<TransactionsHistoryEntity>();

    public virtual IEnumerable<ComicSavingEntity> ComicSavingEntities { get; set; } = new List<ComicSavingEntity>();

    public virtual IEnumerable<ReadingHistoryEntity> ReadingHistorieEntities { get; set; } = new List<ReadingHistoryEntity>();

    public virtual IEnumerable<ReviewComicEntity> ReviewComicEntities { get; set; } = new List<ReviewComicEntity>();

    public virtual IEnumerable<ReviewChapterEntity> ReviewChapterEntities { get; set; } = new List<ReviewChapterEntity>();

    public virtual IEnumerable<BuyingHistoryEntity> BuyingHistorieEntities { get; set; } = new List<BuyingHistoryEntity>();

    public virtual IEnumerable<ComicLikeEntity> ComicLikeEntities { get; set; } = new List<ComicLikeEntity>();
}
