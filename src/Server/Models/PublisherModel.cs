using System;
using System.Collections.Generic;

namespace Model;

public class PublisherModel
{
    public Guid PublisherIdentifier { get; set; }

    public Guid UserIdentifier { get; set; }

    public string PublisherDescription { get; set; }

    public UserModel UserModel { get; set; }

    public ICollection<ComicModel> ComicModels { get; set; }
}
