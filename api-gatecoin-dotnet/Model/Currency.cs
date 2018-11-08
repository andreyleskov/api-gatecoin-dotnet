using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class Currency
    {
        public string Code { get; set; }
        public bool Visible { get; private set; }
        public string DisplayName { get; set; }
        public string Symbol { get; set; }
        public bool IsDigital { get; set; }
        public int DisplayDecimalPlace { get; set; }
        public int withdrawalDecimalPlaces { get; set; }
        public bool WithdrawalsEnabled { get; set; }
        public bool DepositsEnabled { get; set; }
        public decimal WithdrawalFee { get; set; }
    }
}