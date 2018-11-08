using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Public/ExchangeRate", "GET", Summary = @"Get the exchange rates", Notes = @"")]
    public class GetExchangeRate : IReturn<ExchangeRateResponse>
    {
    }
}