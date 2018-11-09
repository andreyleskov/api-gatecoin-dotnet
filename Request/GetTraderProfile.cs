using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/Profile", "GET", Summary = @"Get trader profile", Notes = @"")]
public class GetTraderProfile : IReturn<ProfileResponse>
{
}
}

