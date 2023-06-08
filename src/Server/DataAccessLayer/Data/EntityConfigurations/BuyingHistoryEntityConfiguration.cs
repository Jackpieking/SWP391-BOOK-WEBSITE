using DataAccessLayer.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Data.EntityConfigurations;

public class BuyingHistoryEntityConfiguration : IEntityTypeConfiguration<BuyingHistoryEntity>
{
    public void Configure(EntityTypeBuilder<BuyingHistoryEntity> builder)
    {
        const string TableName = "buying_history";

        builder.ToTable(name: TableName);

        builder.HasKey(keyExpression: buyingHistory => new
        {
            buyingHistory.UserIdentifer,
            buyingHistory.ChapterIdentifer
        });

        builder
            .Property(propertyExpression: buyingHistory => buyingHistory.Date)
            .IsRequired();
    }
}
