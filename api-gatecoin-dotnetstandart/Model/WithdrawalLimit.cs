using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class WithdrawalLimit
    {
        public string Currency { get; set; }
        public decimal Limit { get; set; }
        public decimal Minimum { get; set; }
    }
}