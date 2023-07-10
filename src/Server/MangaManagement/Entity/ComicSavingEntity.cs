using System;

namespace Entity;

public class ComicSavingEntity
{
    public Guid UserIdentifier { get; set; }

    public Guid ComicIdentifier { get; set; }

    public DateTime SavingTime { get; set; }

    public virtual UserEntity UserEntity { get; set; }

    public virtual ComicEntity ComicEntity { get; set; }
}