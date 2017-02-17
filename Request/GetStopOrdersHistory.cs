using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Trade/StopOrdersHistory", "GET", Summary = @"Gets all stop orders for the logged in trader. Max 1000 record.", Notes = @"")]
public class GetStopOrdersHistory : IReturn<StopOrdersResponse>
{
}
}

