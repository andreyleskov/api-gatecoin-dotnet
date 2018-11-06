using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Public/TickerHistory/{CurrencyPair}/{Timeframe}", "GET", Summary = @"Get ticker history",
        Notes = @"Max return 100 record")]
    public class GetTickerHisto : IReturn<HistoTickersResponse>
    {
        [ApiMember(Name = "CurrencyPair", Description = "Currency Pair", ParameterType = "path", DataType = "string",
            IsRequired = false)]
        public string CurrencyPair { get; set; }

        [ApiMember(Name = "Timeframe", Description = "Timeframe (1m,15m,1h,6h,24h)", ParameterType = "path",
            DataType = "string", IsRequired = false)]
        public string Timeframe { get; set; }

        [ApiMember(Name = "Count", Description = "Number of tickers", ParameterType = "query", DataType = "int",
            IsRequired = false)]
        public int Count { get; set; }
    }
}