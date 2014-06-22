using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/ElectronicWallet/Internal/Add/{DigiCurrency}", "POST", Summary = @"Add an digital currency addresses to the logged in user. ", Notes = @"")]
public class AddElectronicAddress : IReturn<CommonResponse>
{
[ApiMember(Name = "DigiCurrency", Description = "Crypto-currency for the address (btc,ltc etc)", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String DigiCurrency {get; set; } 
[ApiMember(Name = "AddressName", Description = "Address Name", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String AddressName {get; set; } 
}
}

