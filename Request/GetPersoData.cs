using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/PersonalData", "GET", Summary = @"Get user personal data", Notes = @"")]
public class GetPersoData : IReturn<PersoDataResponse>
{
}
}

