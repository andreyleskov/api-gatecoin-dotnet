using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/ElectronicWallet/Transactions/Withdrawals/{DigiCurrency}", "POST", Summary = @"Get all external digital currency transactions of the logged in user", Notes = @"")]
public class GetElectronicWalletTransactionsWithdrawals : IReturn<ElectronicWalletTransactionsResponse>
{
[ApiMember(Name = "DigiCurrency", Description = "The digital currency to check", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String DigiCurrency {get; set; } 
[ApiMember(Name = "AddressName", Description = "External address name", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String AddressName {get; set; } 
}
}

