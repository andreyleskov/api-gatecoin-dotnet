using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/CorporateData", "PUT", Summary = @"Update user company data for corporate account", Notes = @"")]
public class UpdateCorpData : IReturn<CommonResponse>
{
[ApiMember(Name = "CompanyName", Description = "Company name", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String CompanyName {get; set; } 
[ApiMember(Name = "RegistrationTaxNumber", Description = "Registration / Tax Number", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String RegistrationTaxNumber {get; set; } 
[ApiMember(Name = "RegistrationDate", Description = "Company registration date", ParameterType = "query", DataType = "datetime", IsRequired = false)]
public System.DateTime RegistrationDate {get; set; } 
[ApiMember(Name = "Nationality", Description = "Nationality", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String Nationality {get; set; } 
[ApiMember(Name = "DirectorFirstName", Description = "Director first name", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String DirectorFirstName {get; set; } 
[ApiMember(Name = "DirectorFamilyName", Description = "Director family name", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String DirectorFamilyName {get; set; } 
[ApiMember(Name = "CompanyPhoneNumber", Description = "Company phone number", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String CompanyPhoneNumber {get; set; } 
[ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String ValidationCode {get; set; } 
}
}

