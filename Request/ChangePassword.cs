using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Auth/ChangePassword", "POST", Summary = @"Change password.", Notes = @"")]
public class ChangePassword : IReturn<CommonResponse>
{
[ApiMember(Name = "OldPassword", Description = "Old password", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String OldPassword {get; set; } 
[ApiMember(Name = "Password", Description = "Password", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String Password {get; set; } 
[ApiMember(Name = "ConfirmPassword", Description = "Confirm password", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String ConfirmPassword {get; set; } 
[ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String ValidationCode {get; set; } 
}
}

