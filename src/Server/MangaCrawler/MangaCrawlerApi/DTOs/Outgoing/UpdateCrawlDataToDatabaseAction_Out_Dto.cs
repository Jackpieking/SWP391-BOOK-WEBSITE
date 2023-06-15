using System;
using System.Collections.Generic;

namespace MangaCrawlerApi.DTOs.Outgoing;

public class UpdateCrawlDataToDatabaseAction_Out_Dto
{
	public ComicDtoType ComicDto { get; set; }

	public class ComicDtoType
	{
		public Guid ComicIdentifier { get; set; }

		public string ComicName { get; set; }

		public string ComicDescription { get; set; }

		public DateOnly ComicPublishedDate { get; set; }

		public string ComicStatus { get; set; }

		public string ComicAvatar { get; set; }

		public IList<CategoryDtoType> ComicCategoryDtos { get; set; }

		public IList<ChapterDtoType> ComicChapterDtos { get; set; }
	}

	public class CategoryDtoType
	{
		public Guid CategoryIdentifier { get; set; }

		public string CategoryName { get; set; }

		public string CategoryDescription { get; set; }
	}

	public class ChapterDtoType
	{
		public Guid ChapterIdentifier { get; set; }

		public string ChapterNumber { get; set; }

		public int ChapterUnlockPrice { get; set; }

		public DateOnly AddedDate { get; set; }

		public IList<ChapterImageDtoType> ChapterImageDtos { get; set; }

		public class ChapterImageDtoType
		{
			public Guid ImageIdentifier { get; set; }

			public short ImageNumber { get; set; }

			public string ImageURL { get; set; }
		}
	}
}
