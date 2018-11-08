using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Merchant/Gateway", "GET", Summary = @"Get the list of gateway", Notes = @"")]
    public class GetMerchantGateway : IReturn<GetMerchantGatewayResponse>
    {
    }
}