﻿using System;

namespace Entity;

public class BuyingHistoryEntity
{
    public Guid UserIdentifier { get; set; }

    public Guid ChapterIdentifier { get; set; }

    public DateTime BuyingDate { get; set; }

    public virtual UserEntity UserEntity { get; set; }

    public virtual ChapterEntity ChapterEntity { get; set; }
}
