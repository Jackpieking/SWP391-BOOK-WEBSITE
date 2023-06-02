using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace MangaManagementAPI.Data.ModelConfigurations;

public class TransactionsHistoryConfiguration : IEntityTypeConfiguration<TransactionsHistory>
{
	public void Configure(EntityTypeBuilder<TransactionsHistory> builder)
	{
		const string TableName = "transaction_history";
		const string NUMERIC_6_0 = "NUMERIC(6, 0)";

		builder.ToTable(name: TableName);

		//primary key: ID
		builder.HasKey(keyExpression: transaction => transaction.TransactionIdentifer);

		builder
			.Property(propertyExpression: transactionHistory => transactionHistory.TransactionIdentifer)
			.HasValueGenerator<GuidValueGenerator>();

		//field: Amount
		builder
			.Property(propertyExpression: transaction => transaction.Amount)
			.HasColumnType(typeName: NUMERIC_6_0)
			.HasDefaultValue(value: default)
			.IsRequired();

		//field: EarnedCoin
		builder
			.Property(propertyExpression: transaction => transaction.EarnedCoin)
			.HasDefaultValue(value: default)
			.IsRequired();

		//field: Date
		builder
			.Property(propertyExpression: transaction => transaction.Date)
			.HasDefaultValue(value: DateTime.UtcNow)
			.IsRequired();

		//Foreign Key: UserIdentifier
		builder
			.Property(propertyExpression: transaction => transaction.UserIdentifier)
			.HasDefaultValue(value: Guid.Empty)
			.IsRequired();
	}
}