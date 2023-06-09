using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace DataAccessLayer.Data.ModelDataSeedings;

public class ChapterEntityDataSeeding : IEntityTypeConfiguration<ChapterEntity>
{
    /// <summary>
    /// Set some seeding data for Chapter Table
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<ChapterEntity> builder)
    {
        /**
		 * Data for Chapter table
		 */
        #region ChapterSeedingData
        ICollection<ChapterEntity> chapters = new List<ChapterEntity>()
        {
            new()
            {
                ChapterIdentifier = new(g: "3f5a415f-caa3-426b-8926-a11a55dc49b0"),
                ChapterNumber = 1,
                ChapterUnlockPrice = 0,
                ComicIdentifier = new(g: "4dfe12e0-cb8a-4282-8e74-3b1e8053f787")
            },
            new()
            {
                ChapterIdentifier = new(g: "ef26e85e-4bd5-414f-9a2b-40bc43534523"),
                ChapterNumber = 1,
                ChapterUnlockPrice = 0,
                ComicIdentifier = new(g: "b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3")
            },
            new()
            {
                ChapterIdentifier = new(g: "94f15b6a-a89b-4546-82a4-98098bab83ff"),
                ChapterNumber = 1,
                ChapterUnlockPrice = 0,
                ComicIdentifier = new(g: "aadadaf7-fc21-4559-a53c-f97eb1ba583f")
            },
            new()
            {
                ChapterIdentifier = new(g: "ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"),
                ChapterNumber = 1,
                ChapterUnlockPrice = 0,
                ComicIdentifier = new(g: "8aa5080b-0212-4b9c-9b70-0afc2bc4b99f")
            },
            new()
            {
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20"),
                ChapterNumber = 1,
                ChapterUnlockPrice = 0,
                ComicIdentifier = new(g: "5d34237a-f44c-4f3f-8495-2b36047e034e")
            }
        };
        #endregion

        builder.HasData(data: chapters);
    }
}
