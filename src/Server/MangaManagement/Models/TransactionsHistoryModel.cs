
using System;

namespace Model;

public class TransactionsHistoryModel
{
    public Guid TransactionIdentifier { get; set; }

    public double TransactionAmount { get; set; }

    public int TransactionCoin { get; set; }

    public DateTime TransactionDate { get; set; }

    public Guid UserIdentifier { get; set; }

    public UserModel UserModel { get; set; }
}