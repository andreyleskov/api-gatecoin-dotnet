using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Notification/Messages", "GET", Summary = @"Get from oldest unread + 3 read message to newest messages", Notes = @"")]
public class GetMessage : IReturn<GetNotificationResponse>
{
}
}

