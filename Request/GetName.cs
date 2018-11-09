using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/Name", "GET", Summary = @"Get user name", Notes = @"")]
public class GetName : IReturn<NameResponse>
{
}
}

