using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Notification/Messages", "POST", Summary = @"Mark all as read", Notes = @"")]
public class ReadAllMessage : IReturn<CommonResponse>
{
}
}

