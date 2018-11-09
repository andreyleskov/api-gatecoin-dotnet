using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Balance/Balances", "GET", Summary = @"Gets the available balance for each currency for the logged in account.", Notes = @"")]
public class GetBalances : IReturn<BalancesResponse>
{
}
}

