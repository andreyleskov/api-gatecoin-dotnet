using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class TradeTransfer
    {
        public string Type { get; set; }
        public string Subtype { get; set; }
        public string Date { get; set; }
        public string Currency { get; set; }
        public string CurrencyPair { get; set; }
        public decimal Amount { get; set; }
        public decimal Price { get; set; }
        public decimal FeeRate { get; set; }
        public string FeeRole { get; set; }
        public decimal CrossFeeRate { get; set; }
    }
}