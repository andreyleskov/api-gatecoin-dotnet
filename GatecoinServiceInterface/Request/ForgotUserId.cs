using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Auth/ForgotUserID", "POST", Summary = @"Request user id", Notes = @"")]
public class ForgotUserId : IReturn<CommonResponse>
{
[ApiMember(Name = "Email", Description = "User email", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String Email {get; set; } 
[ApiMember(Name = "IDNumber", Description = "Identity document number", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String IDNumber {get; set; } 
}
}

