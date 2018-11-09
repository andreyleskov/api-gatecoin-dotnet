using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/RegisterUser", "POST", Summary = @"Initial trader registration.", Notes = @"")]
public class RegisterUser : IReturn<RegisterUserResponse>
{
[ApiMember(Name = "Email", Description = "email", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String Email {get; set; } 
[ApiMember(Name = "Password", Description = "Password", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String Password {get; set; } 
[ApiMember(Name = "IsCorporateAccount", Description = "Personal account or corporate account", ParameterType = "query", DataType = "bool", IsRequired = true)]
public Boolean IsCorporateAccount {get; set; } 
[ApiMember(Name = "language", Description = "language", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String language {get; set; } 
[ApiMember(Name = "ReferralCode", Description = "The referral code of user who recommend you to use gatecoin", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String ReferralCode {get; set; }
[ApiMember(Name = "CaptchaResponse", Description = "Captcha code", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String CaptchaResponse {get; set; }
}
}

