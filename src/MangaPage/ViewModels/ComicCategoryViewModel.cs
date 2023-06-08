using System;

namespace ViewModels;

public class ComicCategoryViewModel
{
    public Guid CategoryIdentifier { get; set; }

    public Guid ComicIdentifier { get; set; }

    public CategoryViewModel Category { get; set; }

    public ComicViewModel Comic { get; set; }
}
