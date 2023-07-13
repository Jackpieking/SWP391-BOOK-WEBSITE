using System;

namespace DTO.Incoming;

public class TransactionHistoryDto
{
    public Guid TransactionIdentifier { get; set; }

    public double TransactionAmount { get; set; }

    public int TransactionCoin { get; set; }

    public DateTime TransactionDate { get; set; }

    public Guid UserIdentifier { get; set; }

    public string Username { get; set; }
}
