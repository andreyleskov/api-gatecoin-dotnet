using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Balance/Withdrawals", "GET",
        Summary = @"Get all account withdrawals, including wire, okpay digital currency, of the logged in user",
        Notes = @"")]
    public class GetAllWithdrawals : IReturn<AllWithdrawalsResponse>
    {
    }
}