using System;
using System.Collections.Generic;

namespace ViewModels;

public class CategoryViewModel
{
    public Guid CategoryIdentifier { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public ICollection<ComicCategoryViewModel> ComicCategories { get; set; } = new List<ComicCategoryViewModel>();
}