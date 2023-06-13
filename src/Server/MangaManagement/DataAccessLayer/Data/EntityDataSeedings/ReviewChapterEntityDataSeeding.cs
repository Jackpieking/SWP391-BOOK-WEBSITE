﻿using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Data.ModelDataSeedings;

public class ReviewChapterEntityDataSeeding : IEntityTypeConfiguration<ReviewChapterEntity>
{
    /// <summary>
    /// Set some seeding data for ReviewChapter Table
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<ReviewChapterEntity> builder)
    {
        /**
		 * Data for ReviewChapter table
		 */
        #region ReviewChapterSeedingData
        ICollection<ReviewChapterEntity> reviewChapters = new List<ReviewChapterEntity>()
        {
            new()
            {
                ChapterIdentifier = new(g: "3f5a415f-caa3-426b-8926-a11a55dc49b0"),
                ChapterRatingStar = 5,
                ChapterComment = "Nó hay vãi",
                UserIdentifier = new(g: "2231dfa9-c0f7-49c9-b0af-dac2cac61c72"),
                ReviewTime = DateTime.UtcNow
            },
            new()
            {
                ChapterIdentifier = new(g: "3f5a415f-caa3-426b-8926-a11a55dc49b0"),
                ChapterRatingStar = 3,
                ChapterComment = "Art đẹp, nhưng cốt truyện không hay",
                UserIdentifier = new(g: "1ef67686-f4ad-48f2-b56c-c828ec53a8d5"),
                ReviewTime = DateTime.UtcNow
            },
            new()
            {
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20"),
                ChapterRatingStar = 2,
                ChapterComment = "Art tạm tạm",
                UserIdentifier = new(g: "2231dfa9-c0f7-49c9-b0af-dac2cac61c72"),
                ReviewTime = DateTime.UtcNow
            },
            new()
            {
                ChapterIdentifier = new(g: "ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"),
                ChapterRatingStar = 1,
                ChapterComment = "Meh không ổn tí nào",
                UserIdentifier = new(g: "c6d20823-3d00-48a0-8074-36587bee2693"),
                ReviewTime = DateTime.UtcNow
            },
            new()
            {
                ChapterIdentifier = new(g: "94f15b6a-a89b-4546-82a4-98098bab83ff"),
                ChapterRatingStar = 4,
                ChapterComment = "Được phết",
                UserIdentifier = new(g: "c6d20823-3d00-48a0-8074-36587bee2693"),
                ReviewTime = DateTime.UtcNow
            }
        };
        #endregion

        builder.HasData(data: reviewChapters);
    }
}