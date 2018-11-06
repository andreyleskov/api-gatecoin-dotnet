using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class ExpressQuickChangeResult
    {
        public string CurrencyFrom { get; set; }
        public string CurrencyTo { get; set; }
        public decimal AmountFrom { get; set; }
        public decimal AmountTo { get; set; }
    }
}