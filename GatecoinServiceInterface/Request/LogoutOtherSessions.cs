using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Auth/LogoutOtherSessions", "POST", Summary = @"Logout other sessions.", Notes = @"")]
public class LogoutOtherSessions : IReturn<CommonResponse>
{
}
}

