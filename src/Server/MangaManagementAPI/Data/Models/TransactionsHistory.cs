using System;

namespace MangaManagementAPI.Data.Models;

public class TransactionsHistory
{
	public Guid TransactionIdentifer { get; set; }

	public double Amount { get; set; }

	public int EarnedCoin { get; set; }

	public DateTime Date { get; set; }

	public Guid UserIdentifier { get; set; }

	public UserInfo UserInfo { get; set; }
}