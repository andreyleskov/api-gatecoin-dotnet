using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Trade/Orders/{OrderID}", "GET", Summary = @"Gets an order for the logged in trader.", Notes = @"")]
public class GetOrder : IReturn<OrderResponse>
{
[ApiMember(Name = "OrderID", Description = "Order ID", ParameterType = "path", DataType = "string", IsRequired = true)]
public System.String OrderId {get; set; } 
}
}

