using System;
using System.Collections.Generic;

namespace ViewModels;

public class ComicViewModel
{
    public Guid ComicIdentifier { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Avatar { get; set; }

    public DateOnly PublishDate { get; set; }

    public double LatestChapter { get; set; }

    public ICollection<ReviewComicViewModel> ReviewComics { get; set; } = new List<ReviewComicViewModel>();

    public ICollection<ComicSavingViewModel> ComicSavings { get; set; } = new List<ComicSavingViewModel>();

    public ICollection<ChapterViewModel> Chapters { get; set; } = new List<ChapterViewModel>();

    public ICollection<ComicCategoryViewModel> ComicCategories { get; set; } = new List<ComicCategoryViewModel>();
}