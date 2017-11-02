using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Auth/SecurityQuestion", "GET", Summary = @"Get security question of the user", Notes = @"")]
public class GetSecurityQuestion : IReturn<SecurityQuestionResponse>
{
}
}

