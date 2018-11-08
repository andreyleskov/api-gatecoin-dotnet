using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class MarketDepthResponse : CommonResponse
    {
        public string Currency { get; set; }
        public List<Limit> Asks { get; set; }
        public List<Limit> Bids { get; set; }
    }
}