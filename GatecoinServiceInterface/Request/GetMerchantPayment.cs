using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Merchant/Payment/{TxID}", "GET", Summary = @"Get payment by txid", Notes = @"")]
public class GetMerchantPayment : IReturn<OrdersResponse>
{
[ApiMember(Name = "TxID", Description = "TxID", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String TxID {get; set; } 
}
}

