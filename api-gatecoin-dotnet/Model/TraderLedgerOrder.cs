using System;
using System.Collections.Generic;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class TraderLedgerOrder
    {
        public long ID { get; set; }
        public string orderID { get; set; }
        public decimal shippingFee { get; set; }
        public string shippingMethod { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string familyName { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string currency { get; set; }
        public DateTime requestDate { get; set; }
        public DateTime shipDate { get; set; }
        public List<TraderLedger> ledgers { get; set; }
    }
}