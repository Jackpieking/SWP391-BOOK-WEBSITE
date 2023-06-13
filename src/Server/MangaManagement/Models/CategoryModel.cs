using System;
using System.Collections.Generic;

namespace Model;

public class CategoryModel
{
    public Guid CategoryIdentifier { get; set; }

    public string CategoryName { get; set; }

    public string CategoryDescription { get; set; }

    public ICollection<ComicCategoryModel> ComicCategoryModels { get; set; }
}