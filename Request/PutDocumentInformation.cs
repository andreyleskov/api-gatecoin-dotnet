using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/DocumentInformation", "PUT", Summary = @"Update Step3 Data", Notes = @"")]
public class PutDocumentInformation : IReturn<CommonResponse>
{
[ApiMember(Name = "IDDocumentNumber", Description = "IDDocumentNumber", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String IDDocumentNumber {get; set; } 
[ApiMember(Name = "IDIssuingCountry", Description = "IDIssuingCountry", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String IDIssuingCountry {get; set; } 
[ApiMember(Name = "IDMimeType", Description = "The mime type of the id document", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String IDMimeType {get; set; } 
[ApiMember(Name = "IDContent", Description = "File content in base64 of id document", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String IDContent {get; set; } 
[ApiMember(Name = "ProofMimeType", Description = "The mime type of the proof document", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String ProofMimeType {get; set; } 
[ApiMember(Name = "ProofContent", Description = "File content in base64 of proof document", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String ProofContent {get; set; } 
}
}

