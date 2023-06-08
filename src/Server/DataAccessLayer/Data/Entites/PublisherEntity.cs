using System;
using System.Collections.Generic;

namespace DataAccessLayer.Data.Entites;

public class PublisherEntity
{
    public Guid PublisherIdentifier { get; set; }

    public Guid UserIdentifier { get; set; }

    public string Description { get; set; }

    public UserInfoEntity UserInfo { get; set; }

    public ICollection<ComicEntity> Comics { get; set; } = new List<ComicEntity>();
}
