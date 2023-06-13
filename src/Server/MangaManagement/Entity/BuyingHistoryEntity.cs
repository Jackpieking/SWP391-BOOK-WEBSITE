using System;

namespace Entity;

public class BuyingHistoryEntity
{
    public Guid UserIdentifier { get; set; }

    public Guid ChapterIdentifier { get; set; }

    public DateTime BuyingDate { get; set; }

    public UserEntity UserEntity { get; set; }

    public ChapterEntity ChapterEntity { get; set; }
}
