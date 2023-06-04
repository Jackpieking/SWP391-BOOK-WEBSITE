using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace MangaManagementAPI.Data.ModelDataSeedings;

public class ReadingHistoryDataSeeding : IEntityTypeConfiguration<ReadingHistory>
{
	/// <summary>
	/// Set some seeding data for ReadingHistory Table
	/// </summary>
	/// <param name="builder"></param>
	public void Configure(EntityTypeBuilder<ReadingHistory> builder)
	{
		/**
		 * Data for ReadingHistory table
		 */
		#region ReadingHistorySeedingData
		ICollection<ReadingHistory> readingHistories = new List<ReadingHistory>()
		{
			new()
			{
				UserIdentifier = new(g: "2231dfa9-c0f7-49c9-b0af-dac2cac61c72"),
				ChapterIdentifier = new(g: "3f5a415f-caa3-426b-8926-a11a55dc49b0"),
				LastReadingTime = DateTime.UtcNow
			},
			new()
			{
				UserIdentifier = new(g: "1ef67686-f4ad-48f2-b56c-c828ec53a8d5"),
				ChapterIdentifier = new(g: "ef26e85e-4bd5-414f-9a2b-40bc43534523"),
				LastReadingTime = DateTime.UtcNow
			},
			new()
			{
				UserIdentifier = new(g: "2231dfa9-c0f7-49c9-b0af-dac2cac61c72"),
				ChapterIdentifier = new(g: "ef26e85e-4bd5-414f-9a2b-40bc43534523"),
				LastReadingTime = DateTime.UtcNow
			},
			new()
			{
				UserIdentifier = new(g: "1ef67686-f4ad-48f2-b56c-c828ec53a8d5"),
				ChapterIdentifier = new(g: "3f5a415f-caa3-426b-8926-a11a55dc49b0"),
				LastReadingTime = DateTime.UtcNow
			},
			new()
			{
				UserIdentifier = new(g: "2231dfa9-c0f7-49c9-b0af-dac2cac61c72"),
				ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20"),
				LastReadingTime = DateTime.UtcNow
			}
		};
		#endregion

		builder.HasData(data: readingHistories);
	}
}
