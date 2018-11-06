using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class Limit
    {
        public decimal Price { get; set; }
        public decimal Volume { get; set; }
    }
}