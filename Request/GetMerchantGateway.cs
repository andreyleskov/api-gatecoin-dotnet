using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Merchant/Gateway", "GET", Summary = @"Get the list of gateway", Notes = @"")]
public class GetMerchantGateway : IReturn<GetMerchantGatewayResponse>
{
}
}

