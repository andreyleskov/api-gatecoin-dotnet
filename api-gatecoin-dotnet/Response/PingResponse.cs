using System;

namespace GatecoinServiceInterface.Response
{
    public class PingResponse : CommonResponse
    {
        public string Message { get; set; }
        public bool IsConnected { get; set; }
        public DateTime ServerTime { get; set; }
        public int VerifLevel { get; set; }
    }
}