using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Merchant/InternalPayment", "POST", Summary = @"InternalPayment", Notes = @"")]
public class NewInternalPayment : IReturn<InternalPaymentResponse>
{
[ApiMember(Name = "ReferralCode", Description = "ReferralCode", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String ReferralCode {get; set; } 
[ApiMember(Name = "Currency", Description = "Currency", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String Currency {get; set; } 
[ApiMember(Name = "Amount", Description = "Amount", ParameterType = "query", DataType = "decimal", IsRequired = false)]
public System.Decimal Amount {get; set; } 
[ApiMember(Name = "Comment", Description = "Comment", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String Comment {get; set; } 
}
}

