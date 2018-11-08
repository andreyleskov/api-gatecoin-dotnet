using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Reference/CurrencyPairs", "GET", Summary = @"Get the currency pair list.", Notes = @"")]
    public class GetCurrencyPairs : IReturn<GetCurrencyPairResponse>
    {
    }
}