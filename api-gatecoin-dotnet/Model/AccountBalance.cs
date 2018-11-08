using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class AccountBalance
    {
        public string Currency { get; set; }
        public decimal Balance { get; set; }
        public decimal AvailableBalance { get; set; }
        public decimal PendingIncoming { get; set; }
        public decimal PendingOutgoing { get; set; }
        public decimal OpenOrder { get; set; }
        public bool IsDigital { get; set; }
    }
}