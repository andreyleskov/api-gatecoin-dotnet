using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Reference/BusinessNatureList", "GET", Summary = @"Get the business nature list.", Notes = @"")]
public class GetBusinessNatureList : IReturn<ReferenceListResponse>
{
}
}

