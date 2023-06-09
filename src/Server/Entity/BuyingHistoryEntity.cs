using System;

namespace Entity;

public class BuyingHistoryEntity
{
    public Guid UserIdentifer { get; set; }

    public Guid ChapterIdentifer { get; set; }

    public DateTime BuyingDate { get; set; }

    public UserEntity UserEntity { get; set; }

    public ChapterEntity ChapterEntity { get; set; }
}
