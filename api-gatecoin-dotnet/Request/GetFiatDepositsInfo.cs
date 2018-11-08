using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Bank/Deposits", "GET", Summary = @"Gets Fiat Deposits Info", Notes = @"")]
    public class GetFiatDepositsInfo : IReturn<FiatDepositsResponse>
    {
    }
}