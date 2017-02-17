using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/Email/RequestVerify", "POST", Summary = @"Request for verification email", Notes = @"")]
public class RequestVerifyEmail : IReturn<CommonResponse>
{
[ApiMember(Name = "IsPrimary", Description = "Primary or secondary email", ParameterType = "query", DataType = "bool", IsRequired = true)]
public Boolean IsPrimary {get; set; } 
}
}

