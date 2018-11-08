using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class OkpayTransaction
    {
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public string TxId { get; set; }
        public string IpAddress { get; set; }
        public DateTime Date { get; set; }
        public DateTime TransferDate { get; set; }
        public string WalletId { get; set; }
        public string Label { get; set; }
    }
}