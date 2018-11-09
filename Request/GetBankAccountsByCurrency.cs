using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Bank/UserAccounts/{Currency}", "GET", Summary = @"Gets all the bank accounts related to the logged in user.", Notes = @"")]
public class GetBankAccountsByCurrency : IReturn<BankAccountsResponse>
{
[ApiMember(Name = "Currency", Description = "currency of bank account", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String Currency {get; set; } 
}
}

