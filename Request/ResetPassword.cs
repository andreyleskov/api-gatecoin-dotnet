using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Auth/ResetPassword", "POST", Summary = @"Reset password", Notes = @"Request for reset code in /Auth/ForgotPassword")]
public class ResetPassword : IReturn<CommonResponse>
{
[ApiMember(Name = "UserID", Description = "User ID", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String UserID {get; set; } 
[ApiMember(Name = "ResetCode", Description = "Request code from email", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String ResetCode {get; set; } 
[ApiMember(Name = "Password", Description = "Password", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String Password {get; set; } 
[ApiMember(Name = "ConfirmPassword", Description = "Confirm password", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String ConfirmPassword {get; set; } 
[ApiMember(Name = "SecurityAnswer", Description = "Security answer if security question and answer are submitted", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String SecurityAnswer {get; set; } 
}
}

