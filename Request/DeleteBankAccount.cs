using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Bank/UserAccounts/{Currency}/{Label}", "DELETE", Summary = @"Delete an account of the logged in user", Notes = @"")]
public class DeleteBankAccount : IReturn<CommonResponse>
{
[ApiMember(Name = "Currency", Description = "Currency of the bank account", ParameterType = "path", DataType = "string", IsRequired = true)]
public System.String Currency {get; set; } 
[ApiMember(Name = "Label", Description = "Bank account label (for use on Gatecoin website only)", ParameterType = "path", DataType = "string", IsRequired = true)]
public System.String Label {get; set; } 
[ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String ValidationCode {get; set; } 
}
}

