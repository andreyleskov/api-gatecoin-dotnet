using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Notification/Messages/{ID}", "POST", Summary = @"Mark as read", Notes = @"")]
public class ReadMessage : IReturn<CommonResponse>
{
[ApiMember(Name = "ID", Description = "Id of the Notification", ParameterType = "path", DataType = "long", IsRequired = false)]
public Int64 ID {get; set; } 
}
}

