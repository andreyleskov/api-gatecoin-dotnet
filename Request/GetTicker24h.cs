using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Public/LiveTicker", "GET", Summary = @"Get live ticker for all currency", Notes = @"")]
public class GetTicker24h : IReturn<TickersResponse>
{
}
}

