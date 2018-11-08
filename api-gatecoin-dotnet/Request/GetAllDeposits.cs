using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Balance/Deposits", "GET",
        Summary = @"Get all account deposits, including wire, okpay and digital currency, of the logged in user",
        Notes = @"")]
    public class GetAllDeposits : IReturn<AllDepositsResponse>
    {
    }
}