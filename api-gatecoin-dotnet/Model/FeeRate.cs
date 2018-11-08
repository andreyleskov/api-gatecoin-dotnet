using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class FeeRate
    {
        public string CurrencyPair { get; set; }
        public decimal TakerFeeRate { get; set; }
        public decimal MakerFeeRate { get; set; }
    }
}