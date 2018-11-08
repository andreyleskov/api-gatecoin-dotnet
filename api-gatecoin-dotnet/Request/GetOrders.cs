using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Trade/Orders", "GET", Summary = @"Gets open orders for the logged in trader.", Notes = @"")]
    public class GetOrders : IReturn<OrdersResponse>
    {
    }
}