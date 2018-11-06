using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class TickersResponse : CommonResponse
    {
        public List<LiveTicker> Tickers { get; set; }
    }
}