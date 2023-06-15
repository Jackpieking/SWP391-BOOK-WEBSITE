using Entity;
using System;
using System.Collections.Generic;

namespace Model;

public class ComicModel
{
	public Guid ComicIdentifier { get; set; }

	public Guid PublisherIdentifier { get; set; }

	public string ComicName { get; set; }

	public string ComicDescription { get; set; }

	public string ComicAvatar { get; set; }

	public DateOnly ComicPublishedDate { get; set; }

	public string ComicStatus { get; set; }

	public PublisherModel PublisherModel { get; set; }

	public ICollection<ReviewComicModel> ReviewComicModels { get; set; }

	public ICollection<ComicSavingModel> ComicSavingModels { get; set; }

	public ICollection<ChapterModel> ChapterModels { get; set; }

	public ICollection<ComicCategoryModel> ComicCategoryModels { get; set; }

	public ICollection<ComicLikeModel> ComicLikeModels { get; set; }
}