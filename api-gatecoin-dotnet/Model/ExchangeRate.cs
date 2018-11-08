using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class ExchangeRate
    {
        public string BuyingCurrency { get; set; }
        public string SellingCurrency { get; set; }
        public decimal Rate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}