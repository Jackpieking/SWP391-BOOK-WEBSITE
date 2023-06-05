using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace MangaManagementAPI.Data.ModelDataSeedings;

public class TransactionHistoryDataSeeding : IEntityTypeConfiguration<TransactionsHistory>
{
	/// <summary>
	/// Set some seeding data for TransactionHistory Table
	/// </summary>
	/// <param name="builder"></param>
	public void Configure(EntityTypeBuilder<TransactionsHistory> builder)
	{
		/**
		 * Data for TransactionHistory table
		 */
		#region TransactionHistorySeedingData
		ICollection<TransactionsHistory> transactionsHistories = new List<TransactionsHistory>()
		{
			new()
			{
				TransactionIdentifier = Guid.NewGuid(),
				Amount = 100000,
				EarnedCoin = 100,
				Date = DateTime.UtcNow,
				UserIdentifier = new(g: "2231dfa9-c0f7-49c9-b0af-dac2cac61c72")
			},
			new()
			{
				TransactionIdentifier = Guid.NewGuid(),
				Amount = 50000,
				EarnedCoin = 50,
				Date = DateTime.UtcNow,
				UserIdentifier = new(g: "2231dfa9-c0f7-49c9-b0af-dac2cac61c72")
			},
			new()
			{
				TransactionIdentifier = Guid.NewGuid(),
				Amount = 200000,
				EarnedCoin = 200,
				Date = DateTime.UtcNow,
				UserIdentifier = new(g: "1ef67686-f4ad-48f2-b56c-c828ec53a8d5")
			}
		};
		#endregion

		builder.HasData(data: transactionsHistories);
	}
}
