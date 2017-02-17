using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/Name", "PUT", Summary = @"Update user name", Notes = @"")]
public class UpdateName : IReturn<CommonResponse>
{
[ApiMember(Name = "FamilyName", Description = "Family Name", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String FamilyName {get; set; } 
[ApiMember(Name = "GivenName", Description = "Given Name", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String GivenName {get; set; } 
[ApiMember(Name = "Alias", Description = "Alias", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String Alias {get; set; } 
[ApiMember(Name = "Password", Description = "Require password confirm to change names", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String Password {get; set; } 
[ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String ValidationCode {get; set; } 
}
}

