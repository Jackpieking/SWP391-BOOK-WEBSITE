using DataAccessLayer.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Data.EntityConfigurations;

public class TransactionsHistoryEntityConfiguration : IEntityTypeConfiguration<TransactionsHistoryEntity>
{
    /// <summary>
    /// Configure TransactionsHistory table fiels and relationships
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<TransactionsHistoryEntity> builder)
    {
        const string TableName = "transaction_history";
        const string NUMERIC_6_0 = "NUMERIC(6, 0)";
        const string GEN_RANDOM_UUID = "gen_random_uuid()";

        builder.ToTable(name: TableName);

        //primary key: ID
        builder.HasKey(keyExpression: transaction => transaction.TransactionIdentifier);

        builder
            .Property(propertyExpression: transactionHistory => transactionHistory.TransactionIdentifier)
            .HasDefaultValueSql(sql: GEN_RANDOM_UUID);

        //field: Amount
        builder
            .Property(propertyExpression: transaction => transaction.Amount)
            .HasColumnType(typeName: NUMERIC_6_0)
            .IsRequired();

        //field: EarnedCoin
        builder
            .Property(propertyExpression: transaction => transaction.Coin)
            .IsRequired();

        //field: Date
        builder
            .Property(propertyExpression: transaction => transaction.Date)
            .IsRequired();
    }
}