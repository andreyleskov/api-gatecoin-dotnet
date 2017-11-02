using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Merchant/Payment", "GET", Summary = @"Get latest 100 payments", Notes = @"")]
public class GetMerchantPayments : IReturn<OrdersResponse>
{
}
}

