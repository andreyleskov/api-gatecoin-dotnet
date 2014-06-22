using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/APIKey/GetAPIKey", "GET", Summary = @"Get API Key for logged in user", Notes = @"")]
public class GetAPIKey : IReturn<GetAPIKeyResponse>
{
}
}

