using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/FeeRate", "GET", Summary = @"Get fee rate of logged in user", Notes = @"")]
public class GetFeeRate : IReturn<FeeRateResponse>
{
}
}

