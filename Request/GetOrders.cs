using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Orders", "GET", Summary = @"Gets open orders for the logged in trader.", Notes = @"")]
public class GetOrders : IReturn<OrdersResponse>
{
}
}

