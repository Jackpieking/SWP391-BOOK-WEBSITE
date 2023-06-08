using MangaManagementAPI.Data.Entites;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Data.Entites;

public class Publisher
{
    public Guid PublisherIdentifier { get; set; }

    public Guid UserIdentifier { get; set; }

    public string Description { get; set; }

    public UserInfo UserInfo { get; set; }

    public ICollection<Comic> Comics { get; set; } = new List<Comic>();
}
