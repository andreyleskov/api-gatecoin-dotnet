using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class Transaction
    {
        public long TransactionId { get; set; }
        public DateTime TransactionTime { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public string CurrencyPair { get; set; }
        public string Way { get; set; }
        public string AskOrderId { get; set; }
        public string BidOrderId { get; set; }
    }
}