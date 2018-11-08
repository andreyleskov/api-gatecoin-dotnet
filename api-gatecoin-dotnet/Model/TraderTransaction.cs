using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class TraderTransaction
    {
        public long TransactionId { get; set; }
        public DateTime TransactionTime { get; set; }
        public string AskOrderID { get; set; }
        public string BidOrderID { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public string CurrencyPair { get; set; }
        public string Way { get; set; }
        public string FeeRole { get; set; }
        public decimal FeeRate { get; set; }
        public decimal? CrossFeeRate { get; set; }
    }
}