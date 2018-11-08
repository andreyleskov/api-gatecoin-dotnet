using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class TraderLedger
    {
        public string model { get; set; }
        public int amount { get; set; }
        public decimal price { get; set; }
        public string currency { get; set; }
    }
}