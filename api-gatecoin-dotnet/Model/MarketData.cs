using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class MarketData
    {
        public string CurrencyPair { get; set; }
        public decimal Open { get; set; }
        public decimal Last { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Volume { get; set; }
        public decimal Vwap { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}