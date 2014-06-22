using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Orders/CancelAllOrder", "POST", Summary = @"Cancels all existing order", Notes = @"")]
public class CancelOrders : IReturn<CommonResponse>
{
}
}

