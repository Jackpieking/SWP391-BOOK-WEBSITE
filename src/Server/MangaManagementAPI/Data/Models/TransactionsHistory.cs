using System;

namespace MangaManagementAPI
{
    public class TransactionsHistory
    {
        public int ID {get; set;}

        public double Amount {get; set;}

        public int EarnedCoin {get; set;}

        public DateTime TransactionDate {get; set;}

    	public Guid UserIdentifier { get; set; }
    }
    
}