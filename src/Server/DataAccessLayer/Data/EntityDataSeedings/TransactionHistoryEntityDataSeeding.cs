using DataAccessLayer.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Data.ModelDataSeedings;

public class TransactionHistoryEntityDataSeeding : IEntityTypeConfiguration<TransactionsHistoryEntity>
{
    /// <summary>
    /// Set some seeding data for TransactionHistory Table
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<TransactionsHistoryEntity> builder)
    {
        /**
		 * Data for TransactionHistory table
		 */
        #region TransactionHistorySeedingData
        ICollection<TransactionsHistoryEntity> transactionsHistories = new List<TransactionsHistoryEntity>()
        {
            new()
            {
                TransactionIdentifier = Guid.NewGuid(),
                Amount = 100000,
                Coin = 100,
                Date = DateTime.UtcNow,
                UserIdentifier = new(g: "2231dfa9-c0f7-49c9-b0af-dac2cac61c72")
            },
            new()
            {
                TransactionIdentifier = Guid.NewGuid(),
                Amount = 50000,
                Coin = 50,
                Date = DateTime.UtcNow,
                UserIdentifier = new(g: "2231dfa9-c0f7-49c9-b0af-dac2cac61c72")
            },
            new()
            {
                TransactionIdentifier = Guid.NewGuid(),
                Amount = 200000,
                Coin = 200,
                Date = DateTime.UtcNow,
                UserIdentifier = new(g: "1ef67686-f4ad-48f2-b56c-c828ec53a8d5")
            }
        };
        #endregion

        builder.HasData(data: transactionsHistories);
    }
}
