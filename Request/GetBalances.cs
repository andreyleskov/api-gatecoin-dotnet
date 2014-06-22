using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Balance", "GET", Summary = @"Gets the available balance for each currency for the logged in account.", Notes = @"")]
public class GetBalances : IReturn<BalancesResponse>
{
}
}

