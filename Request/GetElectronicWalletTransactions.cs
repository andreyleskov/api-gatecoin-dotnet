using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/ElectronicWallet/Transactions/{DigiCurrency}", "GET", Summary = @"Get all digital currency transactions of the logged in user", Notes = @"")]
public class GetElectronicWalletTransactions : IReturn<ElectronicWalletTransactionsResponse>
{
[ApiMember(Name = "DigiCurrency", Description = "The digital currency to check", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String DigiCurrency {get; set; } 
}
}

