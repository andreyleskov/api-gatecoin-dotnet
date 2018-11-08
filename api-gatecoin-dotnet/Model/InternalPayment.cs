using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class InternalPayment
    {
        public string Requester { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; }
        public string Payer { get; set; }
        public string TxID { get; set; }
    }
}