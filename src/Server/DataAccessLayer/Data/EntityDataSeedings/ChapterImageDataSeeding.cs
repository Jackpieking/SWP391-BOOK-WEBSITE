using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.IO;

namespace MangaManagementAPI.Data.ModelDataSeedings;

public class ChapterImageDataSeeding : IEntityTypeConfiguration<ChapterImage>
{
	/// <summary>
	/// Set some seeding data for Chapter Image Table
	/// </summary>
	/// <param name="builder"></param>
	public void Configure(EntityTypeBuilder<ChapterImage> builder)
	{
		/**
		 * Data for ChapterImage table
		 */
		#region ChapterImageSeedingData
		ICollection<ChapterImage> chapterImages = new List<ChapterImage>()
		{
			new()
			{
				ImageIdentifier = new(g: "1753ec49-2e45-4eec-ad77-44c514f19d35"),
				ImageNumber = 1,
				ImageURL = Path.Combine("C:", "Users", "USER", "Downloads", "pic1.jpg"),
				ChapterIdentifier = new(g: "3f5a415f-caa3-426b-8926-a11a55dc49b0")
			},
			new()
			{
				ImageIdentifier = new(g: "d531039b-1797-4b16-9302-349a6b13b331"),
				ImageNumber = 1,
				ImageURL = Path.Combine("C:", "Users", "USER", "Downloads", "pic1.jpg"),
				ChapterIdentifier = new(g: "ef26e85e-4bd5-414f-9a2b-40bc43534523")
			},
			new()
			{
				ImageIdentifier = new(g: "27cddd0a-a8b2-4173-b951-0bedac4ce505"),
				ImageNumber = 1,
				ImageURL = Path.Combine("C:", "Users", "USER", "Downloads", "pic1.jpg"),
				ChapterIdentifier = new(g: "94f15b6a-a89b-4546-82a4-98098bab83ff")
			},
			new()
			{
				ImageIdentifier = new(g: "ef7ff0f1-ae92-4887-b7fe-b93a43f36399"),
				ImageNumber = 1,
				ImageURL = Path.Combine("C:", "Users", "USER", "Downloads", "pic1.jpg"),
				ChapterIdentifier = new(g: "ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80")
			},
			new()
			{
				ImageIdentifier = new(g: "ad981387-1e98-4036-8934-868c5e0880a9"),
				ImageNumber = 1,
				ImageURL = Path.Combine("C:", "Users", "USER", "Downloads", "pic1.jpg"),
				ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
			}

		};
		#endregion

		builder.HasData(data: chapterImages);
	}
}
