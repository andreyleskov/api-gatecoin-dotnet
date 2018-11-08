using GatecoinServiceInterface.Model;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/{CurrencyPair}/Trades", "GET", Summary = @"Gets all trades", Notes = @"")]
    public class GetTrades : IReturn<TradesResponse>
    {
        [ApiMember(Name = "CurrencyPair", Description = "Currency Pair", ParameterType = "path", DataType = "string",
            IsRequired = false)]
        public string CurrencyPair { get; set; }

        [ApiMember(Name = "Since", Description = "Get trades from specific tid", ParameterType = "query",
            DataType = "long", IsRequired = false)]
        public long? Since { get; set; }
    }
}