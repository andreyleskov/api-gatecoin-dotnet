using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/DocumentID", "PUT", Summary = @"Update ID document meta data", Notes = @"")]
public class UpdateDocument_ID : IReturn<CommonResponse>
{
[ApiMember(Name = "DocumentNumber", Description = "Document number of the uploaded document", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String DocumentNumber {get; set; } 
[ApiMember(Name = "IssuingCountry", Description = "Issuing country of the uploaded document", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String IssuingCountry {get; set; } 
}
}

