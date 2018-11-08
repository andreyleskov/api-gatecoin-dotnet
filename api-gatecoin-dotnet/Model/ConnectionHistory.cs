using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class ConnectionHistory
    {
        public DateTime Time { get; set; }
        public string IP { get; set; }
        public string Country { get; set; }
        public bool IsSuccess { get; set; }
    }
}