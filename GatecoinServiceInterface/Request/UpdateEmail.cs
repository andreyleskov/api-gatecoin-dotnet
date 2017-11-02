using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/Email", "PUT", Summary = @"Update user email", Notes = @"")]
public class UpdateEmail : IReturn<CommonResponse>
{
[ApiMember(Name = "Email", Description = "Email", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String Email {get; set; } 
[ApiMember(Name = "Email2", Description = "2nd Email", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String Email2 {get; set; } 
}
}

