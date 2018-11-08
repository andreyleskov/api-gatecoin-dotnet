using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Reference/Currencies", "GET", Summary = @"Get the currency list.", Notes = @"")]
    public class GetCurrencies : IReturn<GetCurrenciesResponse>
    {
    }
}