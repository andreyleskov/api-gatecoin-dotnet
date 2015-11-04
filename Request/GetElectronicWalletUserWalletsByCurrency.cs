using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/ElectronicWallet/UserWallets/{DigiCurrency}", "GET", Summary = @"Gets all external digital currency addresses related to the logged in user by currency. ", Notes = @"")]
public class GetElectronicWalletUserWalletsByCurrency : IReturn<ElectronicAddressesResponse>
{
[ApiMember(Name = "DigiCurrency", Description = "Crypto-currency for the address (btc,ltc etc)", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String DigiCurrency {get; set; } 
}
}

