using System;

namespace Entity;

public class TransactionsHistoryEntity
{
    public Guid TransactionIdentifier { get; set; }

    public double TransactionAmount { get; set; }

    public int TransactionCoin { get; set; }

    public DateTime TransactionDate { get; set; }

    public Guid UserIdentifier { get; set; }

    public virtual UserEntity UserEntity { get; set; }
}