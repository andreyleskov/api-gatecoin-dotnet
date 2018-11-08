using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Info/ReferenceCurrency", "GET", Summary = @"Get user's reference currency", Notes = @"")]
    public class GetReferenceCurrency : IReturn<ReferenceCurrencyResponse>
    {
    }
}