using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Public/LiveTicker/{CurrencyPair}", "GET", Summary = @"Get live ticker by currency", Notes = @"")]
    public class GetTicker : IReturn<TickerResponse>
    {
        [ApiMember(Name = "CurrencyPair", Description = "Currency Pair", ParameterType = "path", DataType = "string",
            IsRequired = false)]
        public string CurrencyPair { get; set; }
    }
}