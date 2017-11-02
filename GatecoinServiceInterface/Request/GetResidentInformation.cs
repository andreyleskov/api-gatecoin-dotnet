using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/ResidentInformation", "GET", Summary = @"Get Step2 Data", Notes = @"")]
public class GetResidentInformation : IReturn<ResidentInformationResponse>
{
}
}

