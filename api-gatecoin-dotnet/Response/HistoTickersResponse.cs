using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class HistoTickersResponse : CommonResponse
    {
        public List<MarketData> Tickers { get; set; }
    }
}