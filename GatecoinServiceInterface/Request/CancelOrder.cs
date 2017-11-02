using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Trade/Orders/{OrderID}", "DELETE", Summary = @"Cancels an existing order", Notes = @"")]
public class CancelOrder : IReturn<CommonResponse>
{
[ApiMember(Name = "OrderID", Description = "Client order Id. Use as order Id", ParameterType = "path", DataType = "string", IsRequired = true)]
public System.String OrderID {get; set; } 
}
}

