using System;

namespace DataAccessLayer.Data.Entites;

public class ComicSavingEntity
{
    public Guid UserIdentifier { get; set; }

    public Guid ComicIdentifier { get; set; }

    public DateTime SavingTime { get; set; }

    public UserInfoEntity UserInfo { get; set; }

    public ComicEntity Comic { get; set; }
}