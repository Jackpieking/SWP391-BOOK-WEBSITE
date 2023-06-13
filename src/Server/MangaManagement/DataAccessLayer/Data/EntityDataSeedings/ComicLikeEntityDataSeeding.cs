using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace DataAccessLayer.Data.EntityConfigurations;

public class ComicLikeEntityDataSeeding : IEntityTypeConfiguration<ComicLikeEntity>
{
    /// <summary>
    /// Set some seeding data for ComicCategory Table
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<ComicLikeEntity> builder)
    {
        /**
         * Data for Comic table
         */
        #region ComicSeedingData
        ICollection<ComicLikeEntity> comicLikeEntities = new List<ComicLikeEntity>()
        {
            new()
            {
                UserIdentifier = new(g: "2231dfa9-c0f7-49c9-b0af-dac2cac61c72"),
                ComicIdentifier = new(g: "4dfe12e0-cb8a-4282-8e74-3b1e8053f787")
            },
            new()
            {
                UserIdentifier = new(g: "1ef67686-f4ad-48f2-b56c-c828ec53a8d5"),
                ComicIdentifier = new(g: "b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3")
            }
        };

        builder.HasData(data: comicLikeEntities);
        #endregion
    }
}
