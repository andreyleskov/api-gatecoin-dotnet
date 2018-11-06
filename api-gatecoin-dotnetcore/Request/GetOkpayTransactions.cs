using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Okpay/Transactions", "GET", Summary = @"Get okpay transfers", Notes = @"")]
    public class GetOkpayTransactions : IReturn<OkpayTransactionResponse>
    {
    }
}