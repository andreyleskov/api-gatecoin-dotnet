using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Trade/UserTrades", "GET", Summary = @"Gets all transactions of logged in user", Notes = @"")]
public class UserTrades : IReturn<UserTransactionsResponse>
{
[ApiMember(Name = "after", Description = "Get 50 transactions each time", ParameterType = "query", DataType = "long", IsRequired = false)]
public System.Int32? after {get; set; } 
}
}

