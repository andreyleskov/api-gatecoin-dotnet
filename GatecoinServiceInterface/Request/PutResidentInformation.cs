using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/ResidentInformation", "PUT", Summary = @"Update Step2 Data", Notes = @"")]
public class PutResidentInformation : IReturn<CommonResponse>
{
[ApiMember(Name = "HomePhone", Description = "Home Phone", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String HomePhone {get; set; } 
[ApiMember(Name = "MobilePhone", Description = "Mobile Phone", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String MobilePhone {get; set; } 
[ApiMember(Name = "Line1", Description = "Address line 1", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String Line1 {get; set; } 
[ApiMember(Name = "Line2", Description = "Address line 2", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String Line2 {get; set; } 
[ApiMember(Name = "City", Description = "City", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String City {get; set; } 
[ApiMember(Name = "State", Description = "State/Province", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String State {get; set; } 
[ApiMember(Name = "ZIP", Description = "ZIP", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String ZIP {get; set; } 
[ApiMember(Name = "CountryCode", Description = "Country of residence", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String CountryCode {get; set; } 
}
}

