using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Balance/Balances", "GET",
        Summary = @"Gets the available balance for each currency for the logged in account.", Notes = @"")]
    public class GetBalances : IReturn<BalancesResponse>
    {
    }
}