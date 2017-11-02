using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/Ledger", "GET", Summary = @"Get the information for the user orders of ledger", Notes = @"")]
public class GetRequestLedger : IReturn<CommonResponse>
{
}
}

