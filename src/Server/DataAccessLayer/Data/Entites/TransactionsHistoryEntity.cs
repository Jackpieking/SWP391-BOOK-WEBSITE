using System;

namespace DataAccessLayer.Data.Entites;

public class TransactionsHistoryEntity
{
    public Guid TransactionIdentifier { get; set; }

    public double Amount { get; set; }

    public int Coin { get; set; }

    public DateTime Date { get; set; }

    public Guid UserIdentifier { get; set; }

    public UserInfoEntity UserInfo { get; set; }
}