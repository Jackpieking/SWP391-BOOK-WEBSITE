using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI.Data.EntityConfigurations;

public class ComicSavingConfiguration : IEntityTypeConfiguration<ComicSaving>
{
    /// <summary>
    /// Configure ComicSaving table fiels and relationships
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<ComicSaving> builder)
    {
        const string TableName = "comic_saving";

        builder.ToTable(name: TableName);

        //Primary - foreign key: [UserIdentifier - ComicIdentifier]
        builder.HasKey(keyExpression: comicSaving => new
        {
            comicSaving.ComicIdentifier,
            comicSaving.UserIdentifier
        });

        //field: SavingTime
        builder
            .Property(propertyExpression: comicSaving => comicSaving.SavingTime)
            .IsRequired();
    }
}