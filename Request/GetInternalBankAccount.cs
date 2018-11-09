using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Bank/Accounts/{Currency}/{Location}", "GET", Summary = @"Get internal bank account for deposit", Notes = @"")]
public class GetInternalBankAccount : IReturn<InternalBankAccountResponse>
{
[ApiMember(Name = "Currency", Description = "Currency of bank account", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String Currency {get; set; } 
[ApiMember(Name = "Location", Description = "Location of bank account", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String Location {get; set; } 
}
}

