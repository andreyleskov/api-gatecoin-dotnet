using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class QuickOrderQuote
    {
        public string CurrencyFrom { get; set; }
        public string CurrencyTo { get; set; }
        public decimal Amount { get; set; }
        public decimal Price { get; set; }
        public string QuoteID { get; set; }
        public bool IsAmountInCurrencyFrom { get; set; }
        public DateTime ValidUntil { get; set; }
    }
}