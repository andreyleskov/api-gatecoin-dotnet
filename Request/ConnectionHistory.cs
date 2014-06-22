using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Auth/Connection_History", "GET", Summary = @"Gets connection history of logged in user", Notes = @"")]
public class ConnectionHistory : IReturn<ConnectionHistoryResponse>
{
}
}

