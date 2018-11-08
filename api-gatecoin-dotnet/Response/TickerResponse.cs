using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class TickerResponse : CommonResponse
    {
        public LiveTicker Ticker { get; set; }
    }
}