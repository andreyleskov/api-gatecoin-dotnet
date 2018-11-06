using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class Trades
    {
        public long Tid { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}