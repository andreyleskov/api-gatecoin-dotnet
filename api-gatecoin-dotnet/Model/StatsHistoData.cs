using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class StatsHistoData
    {
        public long Time { get; set; }
        public decimal Value { get; set; }
    }
}