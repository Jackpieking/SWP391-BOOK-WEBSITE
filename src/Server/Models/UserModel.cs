using Helper.DefinedEnums;
using System;
using System.Collections.Generic;

namespace Model;

public class UserModel
{
    public Guid UserIdentifier { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public string UserFullName { get; set; }

    public DefinedGender UserGender { get; set; }

    public DateOnly UserBirthday { get; set; }

    public string UserPhoneNumber { get; set; }

    public string UserEmail { get; set; }

    public int UserAccountBalance { get; set; }

    public string UserAvatar { get; set; }

    public PublisherModel PublisherModel { get; set; }

    public ICollection<TransactionsHistoryModel> TransactionsHistoryModels { get; set; }

    public ICollection<ComicSavingModel> ComicSavingModels { get; set; }

    public ICollection<ReadingHistoryModel> ReadingHistoryModels { get; set; }

    public ICollection<ReviewComicModel> ReviewComicModels { get; set; }

    public ICollection<ReviewChapterModel> ReviewChapterModels { get; set; }

    public ICollection<BuyingHistoryModel> BuyingHistoryModels { get; set; }
}
