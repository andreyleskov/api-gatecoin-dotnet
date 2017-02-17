using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/SecuritySettings", "PUT", Summary = @"Update verif details of logged in user", Notes = @"")]
public class UpdateVerifDetail : IReturn<VerifDetailResponse>
{
[ApiMember(Name = "LoginWarning", Description = "Receive email warning for login", ParameterType = "query", DataType = "bool", IsRequired = true)]
public Boolean LoginWarning {get; set; } 
[ApiMember(Name = "LoginValidation", Description = "Require validation for login (none = 0, 1 = email, 2 = google auth, 3 = sms)", ParameterType = "query", DataType = "int", IsRequired = true)]
public Int32 LoginValidation {get; set; } 
[ApiMember(Name = "TradeWarning", Description = "Receive email warning for trade", ParameterType = "query", DataType = "bool", IsRequired = true)]
public Boolean TradeWarning {get; set; } 
[ApiMember(Name = "TradeValidation", Description = "Require validation for trade (none = 0, 1 = email, 2 = google auth, 3 = sms)", ParameterType = "query", DataType = "int", IsRequired = true)]
public Int32 TradeValidation {get; set; } 
[ApiMember(Name = "WithdrawValidation", Description = "Require validation for withdraw (none = 0, 1 = email, 2 = google auth, 3 = sms)", ParameterType = "query", DataType = "int", IsRequired = true)]
public Int32 WithdrawValidation {get; set; } 
[ApiMember(Name = "AddAccountValidation", Description = "Require validation for adding bank account and external electronic address (none = 0, 1 = email, 2 = google auth, 3 = sms)", ParameterType = "query", DataType = "int", IsRequired = true)]
public Int32 AddAccountValidation {get; set; } 
[ApiMember(Name = "ChangeDetailsValidation", Description = "Require validation for changing details (none = 0, 1 = email, 2 = google auth, 3 = sms)", ParameterType = "query", DataType = "int", IsRequired = true)]
public Int32 ChangeDetailsValidation {get; set; } 
[ApiMember(Name = "ChangePasswordValidation", Description = "Require validation for changing password (none = 0, 1 = email, 2 = google auth, 3 = sms)", ParameterType = "query", DataType = "int", IsRequired = true)]
public Int32 ChangePasswordValidation {get; set; } 
[ApiMember(Name = "Password", Description = "Require password confirm to change security settings", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String Password {get; set; } 
[ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String ValidationCode {get; set; } 
}
}

