using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI
{
    public class TransactionsHistoryConfiguration : IEntityTypeConfiguration<TransactionsHistory>
    {
        public void Configure(EntityTypeBuilder<TransactionsHistory> builder)
        {
            const string TableName = "Transaction-History";

            builder.ToTable(name: TableName);

            builder.HasKey(keyExpression: transaction => transaction.ID);

            builder.Property(propertyExpression: transaction => transaction.Amount)
                    .HasColumnType(typeName: "MONEY")
                    .IsRequired();

            builder.Property(propertyExpression: transaction => transaction.EarnedCoin)
                    .HasColumnType(typeName: "INT")
                    .IsRequired();

            builder.Property(propertyExpression: transaction => transaction.TransactionDate)
                    .HasColumnType(typeName: "TIMESTAMP")
                    .IsRequired();

            builder.Property(propertyExpression: transaction => transaction.UserIdentifier)
                    .IsRequired();

            builder.HasIndex(indexExpression: transaction => transaction.UserIdentifier)
                    .IsUnique();
        }
    }
}