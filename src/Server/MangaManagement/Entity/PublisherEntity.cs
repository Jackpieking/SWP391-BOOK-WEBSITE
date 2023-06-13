using System;
using System.Collections.Generic;

namespace Entity;

public class PublisherEntity
{
    public Guid PublisherIdentifier { get; set; }

    public Guid UserIdentifier { get; set; }

    public string PublisherDescription { get; set; }

    public UserEntity UserEntity { get; set; }

    public IEnumerable<ComicEntity> ComicEntities { get; set; } = new List<ComicEntity>();
}
