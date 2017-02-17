using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/DocumentCorporation", "POST", Summary = @"Upload registered document document", Notes = @"")]
public class Document_Registered : IReturn<CommonResponse>
{
[ApiMember(Name = "MimeType", Description = "The mime type of the document", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String MimeType {get; set; } 
[ApiMember(Name = "Content", Description = "File content in base64", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String Content {get; set; } 
}
}

