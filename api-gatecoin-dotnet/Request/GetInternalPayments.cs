using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Merchant/InternalPayment", "GET", Summary = @"InternalPayment", Notes = @"")]
    public class GetInternalPayments : IReturn<GetInternalPaymentsResponse>
    {
    }
}