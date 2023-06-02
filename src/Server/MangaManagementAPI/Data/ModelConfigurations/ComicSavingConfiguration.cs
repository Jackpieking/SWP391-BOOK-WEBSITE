using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI.Data.ModelConfigurations;

public class ComicSavingConfiguration : IEntityTypeConfiguration<ComicSaving>
{
	public void Configure(EntityTypeBuilder<ComicSaving> builder)
	{
		const string TableName = "comic_saving";
		const string NOW = "now()";

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
			.HasDefaultValueSql(sql: NOW)
			.IsRequired();
	}
}