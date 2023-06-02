using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MangaManagementAPI.Data.ModelConfigurations;

public class TransactionsHistoryConfiguration : IEntityTypeConfiguration<TransactionsHistory>
{
	public void Configure(EntityTypeBuilder<TransactionsHistory> builder)
	{
		const string TableName = "transaction_history";
		const string NUMERIC_6_0 = "NUMERIC(6, 0)";
		const string GEN_RANDOM_UUID = "gen_random_uuid()";
		const string NOW = "now()";

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
			.HasDefaultValue(value: default(double))
			.IsRequired();

		//field: EarnedCoin
		builder
			.Property(propertyExpression: transaction => transaction.EarnedCoin)
			.HasDefaultValue(value: default(int))
			.IsRequired();

		//field: Date
		builder
			.Property(propertyExpression: transaction => transaction.Date)
			.HasDefaultValueSql(sql: NOW)
			.IsRequired();

		//Foreign Key: UserIdentifier
		builder
			.Property(propertyExpression: transaction => transaction.UserIdentifier)
			.HasDefaultValue(value: Guid.Empty)
			.IsRequired();
	}
}