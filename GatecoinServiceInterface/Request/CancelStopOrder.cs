using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Trade/StopOrders/{ID}", "DELETE", Summary = @"Cancels an existing stop order", Notes = @"")]
public class CancelStopOrder : IReturn<CommonResponse>
{
[ApiMember(Name = "ID", Description = "Client order Id. Use as order Id", ParameterType = "path", DataType = "int", IsRequired = true)]
public Int64 ID {get; set; } 
}
}

