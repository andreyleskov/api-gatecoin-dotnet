using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class MerchantPayment
    {
        public string TxID { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountReceived { get; set; }
        public string Status { get; set; }
        public int Confirmation { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Reference { get; set; }
        public string ExtraData { get; set; }
    }
}