using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class UserQuickOrder
    {
        public string CurrencyFrom { get; set; }
        public string CurrencyTo { get; set; }
        public decimal Amount { get; set; }
        public decimal Price { get; set; }
        public decimal TransactionTime { get; set; }
    }
}