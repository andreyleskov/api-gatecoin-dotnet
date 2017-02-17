using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/SecuritySettings", "GET", Summary = @"Get verif details of logged in user", Notes = @"")]
public class GetVerifDetail : IReturn<VerifDetailResponse>
{
}
}

