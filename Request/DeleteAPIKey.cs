using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/APIKey/DeleteAPIKey/{PublicKey}", "POST", Summary = @"Remove an API key", Notes = @"")]
public class DeleteAPIKey : IReturn<CommonResponse>
{
[ApiMember(Name = "PublicKey", Description = "The public key of API key to delete", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String PublicKey {get; set; } 
}
}

