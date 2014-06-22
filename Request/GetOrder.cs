using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Orders", "POST", Summary = @"Gets an order for the logged in trader.", Notes = @"")]
public class GetOrder : IReturn<OrderResponse>
{
[ApiMember(Name = "clOrderId", Description = "Client order Id. Use as order Id", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String clOrderId {get; set; } 
}
}

