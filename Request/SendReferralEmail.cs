using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/Referral", "POST", Summary = @"Post a referral email", Notes = @"")]
public class SendReferralEmail : IReturn<CommonResponse>
{
[ApiMember(Name = "Email", Description = "Email", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String Email {get; set; } 
}
}

