using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/FeeRate", "GET", Summary = @"Get fee rate of logged in user", Notes = @"")]
    public class GetFeeRate : IReturn<FeeRateResponse>
    {
    }
}