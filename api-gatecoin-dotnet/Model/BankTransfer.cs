using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class BankTransfer
    {
        public long RequestID { get; set; }
        public string Label { get; set; }
        public string BankAccountNumber { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public string TxId { get; set; }
        public string Comment { get; set; }
        public string IpAddress { get; set; }
        public DateTime Date { get; set; }
        public decimal Fee { get; set; }
    }
}