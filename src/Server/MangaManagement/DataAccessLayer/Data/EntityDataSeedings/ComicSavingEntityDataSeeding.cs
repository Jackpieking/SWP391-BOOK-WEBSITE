using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Data.ModelDataSeedings;

public class ComicSavingEntityDataSeeding : IEntityTypeConfiguration<ComicSavingEntity>
{
    /// <summary>
    /// Set some seeding data for ComicSaving Table
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<ComicSavingEntity> builder)
    {
        /**
		 * Data for ComicSaving table
		 */
        #region ComicSavingSeedingData
        ICollection<ComicSavingEntity> comicSavings = new List<ComicSavingEntity>()
        {
            new()
            {
                UserIdentifier = new(g: "c6d20823-3d00-48a0-8074-36587bee2693"),
                ComicIdentifier = new(g: "b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"),
                SavingTime = DateTime.UtcNow,
            },
            new()
            {
                UserIdentifier = new(g: "c6d20823-3d00-48a0-8074-36587bee2693"),
                ComicIdentifier = new(g: "5d34237a-f44c-4f3f-8495-2b36047e034e"),
                SavingTime = DateTime.UtcNow,
            },
            new()
            {
                UserIdentifier = new(g: "c6d20823-3d00-48a0-8074-36587bee2693"),
                ComicIdentifier = new(g: "8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"),
                SavingTime = DateTime.UtcNow,
            },
            new()
            {
                UserIdentifier = new(g: "c6d20823-3d00-48a0-8074-36587bee2693"),
                ComicIdentifier = new(g: "4dfe12e0-cb8a-4282-8e74-3b1e8053f787"),
                SavingTime = DateTime.UtcNow,
            },
            new()
            {
                UserIdentifier = new(g: "c6d20823-3d00-48a0-8074-36587bee2693"),
                ComicIdentifier = new(g: "aadadaf7-fc21-4559-a53c-f97eb1ba583f"),
                SavingTime = DateTime.UtcNow,
            }
        };
        #endregion

        builder.HasData(data: comicSavings);
    }
}
