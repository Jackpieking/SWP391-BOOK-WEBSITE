using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace MangaManagementAPI.Data.ModelDataSeedings;

public class ReviewComicDataSeeding : IEntityTypeConfiguration<ReviewComic>
{
	public void Configure(EntityTypeBuilder<ReviewComic> builder)
	{
		ICollection<ReviewComic> reviewComics = new List<ReviewComic>()
		{
			new()
			{
				UserIdentifier = Guid.Parse(input: "2231dfa9-c0f7-49c9-b0af-dac2cac61c72"),
				ComicIdentifier = Guid.Parse(input: "5d34237a-f44c-4f3f-8495-2b36047e034e"),
				RatingStar = 3,
				Comment = "The artwork is amazing!",
				ReviewTime = DateTime.UtcNow
			},
			new()
			{
				UserIdentifier = Guid.Parse(input: "2231dfa9-c0f7-49c9-b0af-dac2cac61c72"),
				ComicIdentifier = Guid.Parse(input: "8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"),
				RatingStar = 2,
				Comment = "The story line is hard to follow.",
				ReviewTime = DateTime.UtcNow
			},
			new()
			{
				UserIdentifier = Guid.Parse(input : "1ef67686-f4ad-48f2-b56c-c828ec53a8d5"),
				ComicIdentifier = Guid.Parse(input: "5d34237a-f44c-4f3f-8495-2b36047e034e"),
				RatingStar = 5,
				Comment = "I laughed so hard I cried!",
				ReviewTime = DateTime.UtcNow
			},
			new()
			{
				UserIdentifier = Guid.Parse(input : "1ef67686-f4ad-48f2-b56c-c828ec53a8d5"),
				ComicIdentifier = Guid.Parse(input: "8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"),
				RatingStar = 1,
				Comment = "I hated the ending.",
				ReviewTime = DateTime.UtcNow
			},
			new()
			{
				UserIdentifier = Guid.Parse(input: "c6d20823-3d00-48a0-8074-36587bee2693"),
				ComicIdentifier = Guid.Parse(input: "8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"),
				RatingStar = 4,
				Comment = "I wanted more action scenes.",
				ReviewTime = DateTime.UtcNow
			}
		};

		builder.HasData(data: reviewComics);
	}
}
