using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Merchant/Payment", "GET", Summary = @"Get latest 100 payments", Notes = @"")]
    public class GetMerchantPayments : IReturn<OrdersResponse>
    {
    }
}