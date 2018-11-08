using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/{CurrencyPair}/OrderBook", "GET,HEAD", Summary = @"Gets prices and market depth for the currency pair.",
        Notes = @"")]
    public class OrderBook : IReturn<MarketDepthResponse>
    {
        [ApiMember(Name = "CurrencyPair", Description = "The currency pair for which prices are wanted",
            ParameterType = "path", DataType = "string", IsRequired = false)]
        public string CurrencyPair { get; set; }
    }
}