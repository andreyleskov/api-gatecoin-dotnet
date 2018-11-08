using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class TotalWithdrawn
    {
        public string Currency { get; set; }
        public decimal Total { get; set; }
    }
}