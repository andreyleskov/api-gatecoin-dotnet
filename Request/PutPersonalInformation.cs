using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/PersonalInformation", "PUT", Summary = @"Update Step1 Data", Notes = @"")]
public class PutPersonalInformation : IReturn<CommonResponse>
{
[ApiMember(Name = "GivenName", Description = "Given name", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String GivenName {get; set; } 
[ApiMember(Name = "FamilyName", Description = "Family Name", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String FamilyName {get; set; } 
[ApiMember(Name = "Birthday", Description = "Birthday", ParameterType = "query", DataType = "datetime", IsRequired = true)]
public System.DateTime? Birthday {get; set; } 
[ApiMember(Name = "Nationality", Description = "Nationality", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String Nationality {get; set; } 
}
}

