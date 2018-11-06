using System;
using System.Collections.Generic;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class OpenOrder
    {
        public string Code { get; set; }
        public string ClOrderId { get; set; }
        public string OrigClOrderId { get; set; }
        public byte Side { get; set; }
        public decimal Price { get; set; }
        public decimal InitialQuantity { get; set; }
        public decimal RemainingQuantity { get; set; }
        public byte Status { get; set; }
        public string StatusDesc { get; set; }
        public long TranSeqNo { get; set; }
        public byte Type { get; set; }
        public DateTime Date { get; set; }
        public List<TraderTransaction> Trades { get; set; }
    }
}