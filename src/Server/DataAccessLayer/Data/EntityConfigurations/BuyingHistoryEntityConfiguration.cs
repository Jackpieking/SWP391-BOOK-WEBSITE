using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Data.EntityConfigurations;

public class BuyingHistoryEntityConfiguration : IEntityTypeConfiguration<BuyingHistoryEntity>
{
    /// <summary>
    /// Configure BuyingHistory table fiels and relationships
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<BuyingHistoryEntity> builder)
    {
        const string TableName = "buying_history";

        builder.ToTable(name: TableName);

        //Primary key: [UserIdentifier - ChapterIdentifier]
        builder.HasKey(keyExpression: buyingHistory => new
        {
            buyingHistory.UserIdentifer,
            buyingHistory.ChapterIdentifer
        });

        //field: BuyingDate
        builder
            .Property(propertyExpression: buyingHistory => buyingHistory.BuyingDate)
            .IsRequired();
    }
}
