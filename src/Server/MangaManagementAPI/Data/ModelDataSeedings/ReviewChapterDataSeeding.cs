using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace MangaManagementAPI.Data.ModelDataSeedings;

public class ReviewChapterDataSeeding : IEntityTypeConfiguration<ReviewChapter>
{
	public void Configure(EntityTypeBuilder<ReviewChapter> builder)
	{
		ICollection<ReviewChapter> reviewChapters = new List<ReviewChapter>()
		{
			new()
			{
				ChapterIdentifier = new(g: "3f5a415f-caa3-426b-8926-a11a55dc49b0"),
				RatingStar = 5,
				Comment = "It's the best thing I've read in years!",
				UserIdentifier = new(g: "2231dfa9-c0f7-49c9-b0af-dac2cac61c72"),
				ReviewTime = DateTime.UtcNow
			},
			new()
			{
				ChapterIdentifier = new(g: "3f5a415f-caa3-426b-8926-a11a55dc49b0"),
				RatingStar = 3,
				Comment = "It's ok, but not great.",
				UserIdentifier = new(g: "1ef67686-f4ad-48f2-b56c-c828ec53a8d5"),
				ReviewTime = DateTime.UtcNow
			},
			new()
			{
				ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20"),
				RatingStar = 2,
				Comment = "I didn't like it at all.",
				UserIdentifier = new(g: "2231dfa9-c0f7-49c9-b0af-dac2cac61c72"),
				ReviewTime = DateTime.UtcNow
			},
			new()
			{
				ChapterIdentifier = new(g: "ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"),
				RatingStar = 1,
				Comment = "It's the worst.",
				UserIdentifier = new(g: "c6d20823-3d00-48a0-8074-36587bee2693"),
				ReviewTime = DateTime.UtcNow
			},
			new()
			{
				ChapterIdentifier = new(g: "94f15b6a-a89b-4546-82a4-98098bab83ff"),
				RatingStar = 4,
				Comment = "It's pretty good!",
				UserIdentifier = new(g: "c6d20823-3d00-48a0-8074-36587bee2693"),
				ReviewTime = DateTime.UtcNow
			}
		};

		builder.HasData(data: reviewChapters);
	}
}
