using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/Email", "GET", Summary = @"Get user email", Notes = @"")]
public class GetEmail : IReturn<EmailResponse>
{
}
}

