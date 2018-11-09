using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Auth/Logout", "POST", Summary = @"Logout from the current session.", Notes = @"")]
public class Logout : IReturn<CommonResponse>
{
}
}

