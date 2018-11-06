using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class Reward
    {
        public decimal amount { get; set; }
        public double fromDate { get; set; }
        public double toDate { get; set; }
    }
}