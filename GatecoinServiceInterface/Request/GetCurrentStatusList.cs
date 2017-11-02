using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Reference/CurrentStatusList", "GET", Summary = @"Get the current status list.", Notes = @"")]
public class GetCurrentStatusList : IReturn<ReferenceListResponse>
{
}
}

