using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Bank/InternalBankAccounts/{Currency}", "GET", Summary = @"Get internal bank account for deposit", Notes = @"")]
public class GetInternalBankAccount : IReturn<BankAccountResponse>
{
[ApiMember(Name = "Currency", Description = "Currency of bank account", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String Currency {get; set; } 
}
}

