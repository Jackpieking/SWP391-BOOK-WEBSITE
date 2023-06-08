using DataAccessLayer.Models;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Data.Entites;

public class PublisherModel
{
    public Guid PublisherIdentifier { get; set; }

    public Guid UserIdentifier { get; set; }

    public string Description { get; set; }

    public UserInfoModel UserInfo { get; set; }

    public ICollection<ComicModel> Comics { get; set; } = new List<ComicModel>();
}
