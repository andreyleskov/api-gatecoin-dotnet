using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Trade/QuickChange", "GET", Summary = @"Get all executed quick orders of logged in user", Notes = @"")]
    public class GetQuickOrders : IReturn<TransactionsResponse>
    {
    }
}