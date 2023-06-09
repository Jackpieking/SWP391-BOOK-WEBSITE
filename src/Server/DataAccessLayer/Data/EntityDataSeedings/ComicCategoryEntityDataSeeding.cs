using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace DataAccessLayer.Data.ModelDataSeedings;

public class ComicCategoryEntityDataSeeding : IEntityTypeConfiguration<ComicCategoryEntity>
{
    /// <summary>
    /// Set some seeding data for ComicCategory Table
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<ComicCategoryEntity> builder)
    {
        /**
		 * Data for ComicCategory table
		 */
        #region ComicCategorySeedingData
        ICollection<ComicCategoryEntity> comicCategories = new List<ComicCategoryEntity>()
        {
            #region 4dfe12e0-cb8a-4282-8e74-3b1e8053f787
            new()
            {
                CategoryIdentifier = new(g: "edc6e266-7b95-4723-a420-8e51a78d99bc"),
                ComicIdentifier = new(g: "4dfe12e0-cb8a-4282-8e74-3b1e8053f787"),
            },
            new()
            {
                CategoryIdentifier = new(g: "72522ef6-6633-4519-872b-36bc0675e328"),
                ComicIdentifier = new(g: "4dfe12e0-cb8a-4282-8e74-3b1e8053f787"),
            },
            new()
            {
                CategoryIdentifier = new(g: "322dbf35-54aa-416e-b121-42fc20b9d94b"),
                ComicIdentifier = new(g: "4dfe12e0-cb8a-4282-8e74-3b1e8053f787"),
            },
            new()
            {
                CategoryIdentifier = new(g: "1b9d5460-4c32-4703-b4bd-c52e5fb6e943"),
                ComicIdentifier = new(g: "4dfe12e0-cb8a-4282-8e74-3b1e8053f787"),
            },
            new()
            {
                CategoryIdentifier = new(g: "ad2149ef-ac21-4759-88d8-e586e850e299"),
                ComicIdentifier = new(g: "4dfe12e0-cb8a-4282-8e74-3b1e8053f787"),
            },
	        #endregion
            #region aadadaf7-fc21-4559-a53c-f97eb1ba583f
            new()
            {
                CategoryIdentifier = new(g: "ddebafec-b0a5-49c6-ac6c-261079080dce"),
                ComicIdentifier = new(g: "aadadaf7-fc21-4559-a53c-f97eb1ba583f"),
            },
            new()
            {
                CategoryIdentifier = new(g: "72522ef6-6633-4519-872b-36bc0675e328"),
                ComicIdentifier = new(g: "aadadaf7-fc21-4559-a53c-f97eb1ba583f"),
            },
	        #endregion
            #region 8aa5080b-0212-4b9c-9b70-0afc2bc4b99f
            new()
            {
                CategoryIdentifier = new(g: "ddebafec-b0a5-49c6-ac6c-261079080dce"),
                ComicIdentifier = new(g: "8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"),
            },
            new()
            {
                CategoryIdentifier = new(g: "322dbf35-54aa-416e-b121-42fc20b9d94b"),
                ComicIdentifier = new(g: "8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"),
            },
	        #endregion
            #region 5d34237a-f44c-4f3f-8495-2b36047e034e
            new()
            {
                CategoryIdentifier = new(g: "edc6e266-7b95-4723-a420-8e51a78d99bc"),
                ComicIdentifier = new(g: "5d34237a-f44c-4f3f-8495-2b36047e034e"),
            },
            new()
            {
                CategoryIdentifier = new(g: "72522ef6-6633-4519-872b-36bc0675e328"),
                ComicIdentifier = new(g: "5d34237a-f44c-4f3f-8495-2b36047e034e"),
            },
            new()
            {
                CategoryIdentifier = new(g: "322dbf35-54aa-416e-b121-42fc20b9d94b"),
                ComicIdentifier = new(g: "5d34237a-f44c-4f3f-8495-2b36047e034e"),
            },
            new()
            {
                CategoryIdentifier = new(g: "414e65b4-1949-48ce-a764-26fb66e95550"),
                ComicIdentifier = new(g: "5d34237a-f44c-4f3f-8495-2b36047e034e"),
            },
	        #endregion
            #region b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3
            new()
            {
                CategoryIdentifier = new(g: "1b9d5460-4c32-4703-b4bd-c52e5fb6e943"),
                ComicIdentifier = new(g: "b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"),
            },
            new()
            {
                CategoryIdentifier = new(g: "414e65b4-1949-48ce-a764-26fb66e95550"),
                ComicIdentifier = new(g: "b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"),
            }
	        #endregion
        };
        #endregion

        builder.HasData(data: comicCategories);
    }
}
