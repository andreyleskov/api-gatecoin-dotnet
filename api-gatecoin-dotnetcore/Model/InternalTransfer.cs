using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class InternalTransfer
    {
        public string Currency { get; set; }
        public string TxId { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public DateTime TransferDate { get; set; }
    }
}