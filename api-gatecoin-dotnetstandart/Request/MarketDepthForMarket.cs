using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Public/MarketDepth/{CurrencyPair}", "GET",
        Summary = @"Gets prices and market depth for the currency pair.", Notes = @"")]
    public class MarketDepthForMarket : IReturn<MarketDepthResponse>
    {
        [ApiMember(Name = "CurrencyPair", Description = "The currency pair for which prices are wanted",
            ParameterType = "path", DataType = "string", IsRequired = false)]
        public string CurrencyPair { get; set; }
    }
}