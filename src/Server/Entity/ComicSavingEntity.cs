using System;

namespace Entity;

public class ComicSavingEntity
{
    public Guid UserIdentifier { get; set; }

    public Guid ComicIdentifier { get; set; }

    public DateTime SavingTime { get; set; }

    public UserEntity UserEntity { get; set; }

    public ComicEntity ComicEntity { get; set; }
}