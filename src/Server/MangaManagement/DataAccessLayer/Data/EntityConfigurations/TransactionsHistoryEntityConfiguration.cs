using Entity;
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

        //primary key: TransactionIdentifier
        builder.HasKey(keyExpression: transaction => transaction.TransactionIdentifier);

        builder
            .Property(propertyExpression: transactionHistory => transactionHistory.TransactionIdentifier)
            .HasDefaultValueSql(sql: GEN_RANDOM_UUID);

        //field: TransactionAmount
        builder
            .Property(propertyExpression: transaction => transaction.TransactionAmount)
            .HasColumnType(typeName: NUMERIC_6_0)
            .IsRequired();

        //field: TransactionCoin
        builder
            .Property(propertyExpression: transaction => transaction.TransactionCoin)
            .IsRequired();

        //field: TransactionDate
        builder
            .Property(propertyExpression: transaction => transaction.TransactionDate)
            .IsRequired();
    }
}