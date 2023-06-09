using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Data.ModelDataSeedings;

public class ReviewComicEntityDataSeeding : IEntityTypeConfiguration<ReviewComicEntity>
{
    /// <summary>
    /// Set some seeding data for ReviewComic Table
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<ReviewComicEntity> builder)
    {
        /**
		 * Data for ReviewComic table
		 */
        #region ReviewComicSeedingData
        ICollection<ReviewComicEntity> reviewComics = new List<ReviewComicEntity>()
        {
            new()
            {
                UserIdentifier = new(g: "2231dfa9-c0f7-49c9-b0af-dac2cac61c72"),
                ComicIdentifier = new(g: "5d34237a-f44c-4f3f-8495-2b36047e034e"),
                ComicRatingStar = 3,
                ComicComment = "Tổng quan về cốt truyện ở mức ổn",
                ReviewTime = DateTime.UtcNow
            },
            new()
            {
                UserIdentifier = new(g: "2231dfa9-c0f7-49c9-b0af-dac2cac61c72"),
                ComicIdentifier = new(g: "8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"),
                ComicRatingStar = 2,
                ComicComment = "Cốt truyện khó hiểu",
                ReviewTime = DateTime.UtcNow
            },
            new()
            {
                UserIdentifier = new(g: "1ef67686-f4ad-48f2-b56c-c828ec53a8d5"),
                ComicIdentifier = new(g: "5d34237a-f44c-4f3f-8495-2b36047e034e"),
                ComicRatingStar = 5,
                ComicComment = "Cười vãi",
                ReviewTime = DateTime.UtcNow
            },
            new()
            {
                UserIdentifier = new(g: "1ef67686-f4ad-48f2-b56c-c828ec53a8d5"),
                ComicIdentifier = new(g: "8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"),
                ComicRatingStar = 1,
                ComicComment = "Tui muốn gud end",
                ReviewTime = DateTime.UtcNow
            },
            new()
            {
                UserIdentifier = new(g: "c6d20823-3d00-48a0-8074-36587bee2693"),
                ComicIdentifier = new(g: "8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"),
                ComicRatingStar = 4,
                ComicComment = "Đánh nhau ít nhưng tổng quan vẫn OK",
                ReviewTime = DateTime.UtcNow
            }
        };
        #endregion

        builder.HasData(data: reviewComics);
    }
}
