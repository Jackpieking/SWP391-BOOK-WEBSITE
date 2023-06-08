using System;

namespace ViewModels;

public class TransactionsHistoryViewModel
{
    public Guid TransactionIdentifier { get; set; }

    public double Amount { get; set; }

    public int EarnedCoin { get; set; }

    public DateTime Date { get; set; }

    public Guid UserIdentifier { get; set; }

    public UserInfoViewModel UserInfo { get; set; }
}