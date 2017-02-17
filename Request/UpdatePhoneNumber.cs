using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/Phone", "PUT", Summary = @"Update user phone number", Notes = @"")]
public class UpdatePhoneNumber : IReturn<CommonResponse>
{
[ApiMember(Name = "HomePhone", Description = "Home phone", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String HomePhone {get; set; } 
[ApiMember(Name = "BusinessPhone", Description = "Business Phone", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String BusinessPhone {get; set; } 
[ApiMember(Name = "MobilePhone", Description = "Mobile Phone", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String MobilePhone {get; set; } 
[ApiMember(Name = "Password", Description = "Require password confirm to change phone number", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String Password {get; set; } 
[ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String ValidationCode {get; set; } 
}
}

