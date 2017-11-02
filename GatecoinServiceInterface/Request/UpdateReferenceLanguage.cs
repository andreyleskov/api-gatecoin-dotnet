using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Info/ReferenceLanguage", "PUT", Summary = @"Update user's reference language", Notes = @"")]
public class UpdateReferenceLanguage : IReturn<CommonResponse>
{
[ApiMember(Name = "language", Description = "language", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String language {get; set; } 
}
}

