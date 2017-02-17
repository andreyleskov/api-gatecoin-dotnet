using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Balance/Balances/{Currency}", "GET", Summary = @"Gets the available balance for s currency for the logged in account.", Notes = @"")]
public class GetBalance : IReturn<BalanceResponse>
{
[ApiMember(Name = "Currency", Description = "Currency to query", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String Currency {get; set; } 
}
}

