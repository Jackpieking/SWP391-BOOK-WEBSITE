using System;

namespace DataAccessLayer.Models;

public class TransactionsHistoryModel
{
	public Guid TransactionIdentifier { get; set; }

	public double Amount { get; set; }

	public int EarnedCoin { get; set; }

	public DateTime Date { get; set; }

	public Guid UserIdentifier { get; set; }

	public UserInfoModel UserInfo { get; set; }
}