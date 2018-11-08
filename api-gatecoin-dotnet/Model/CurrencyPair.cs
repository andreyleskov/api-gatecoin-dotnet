using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class CurrencyPair
    {
        public string Name { get; set; }
        public string TradingCode { get; set; }
        public string BaseCurrency { get; set; }
        public string QuoteCurrency { get; set; }
        public string DisplayName { get; set; }
        public long PriceDecimalPlaces { get; set; }
    }
}