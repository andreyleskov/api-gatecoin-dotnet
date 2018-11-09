using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Merchant/PayInternalPayment", "Post", Summary = @"Pay the payment", Notes = @"")]
public class PayInternalPayment : IReturn<CommonResponse>
{
[ApiMember(Name = "TxID", Description = "TxID", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String TxID {get; set; } 
[ApiMember(Name = "UserName", Description = "UserName", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String UserName {get; set; } 
[ApiMember(Name = "Password", Description = "Password", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String Password {get; set; } 
}
}

