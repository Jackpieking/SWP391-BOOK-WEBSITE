using System;

namespace Model;

public class ComicCategoryModel
{
    public Guid CategoryIdentifier { get; set; }

    public Guid ComicIdentifier { get; set; }

    public CategoryModel CategoryModel { get; set; }

    public ComicModel ComicModel { get; set; }
}
