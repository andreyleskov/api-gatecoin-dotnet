using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Merchant/InternalPayment/{TxID}", "Get", Summary = @"Get payment", Notes = @"")]
public class GetInternalPayment : IReturn<GetInternalPaymentResponse>
{
[ApiMember(Name = "TxID", Description = "TxID", ParameterType = "Path", DataType = "string", IsRequired = true)]
public System.String TxID {get; set; } 
}
}

