using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class LiveTicker
    {
        public string CurrencyPair { get; set; }
        public decimal Open { get; set; }
        public decimal Last { get; set; }
        public decimal LastQ { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Volume { get; set; }
        public decimal Volumn { get; set; }
        public decimal Bid { get; set; }
        public decimal BidQ { get; set; }
        public decimal Ask { get; set; }
        public decimal AskQ { get; set; }
        public decimal Vwap { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}