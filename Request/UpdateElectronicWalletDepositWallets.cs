using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/ElectronicWallet/DepositWallets/{DigiCurrency}/{AddressName}", "PUT", Summary = @"Update the name of an address ", Notes = @"")]
public class UpdateElectronicWalletDepositWallets : IReturn<CommonResponse>
{
[ApiMember(Name = "DigiCurrency", Description = "Crypto-currency for the address (btc,ltc etc)", ParameterType = "path", DataType = "string", IsRequired = true)]
public System.String DigiCurrency {get; set; } 
[ApiMember(Name = "AddressName", Description = "Address name", ParameterType = "path", DataType = "string", IsRequired = true)]
public System.String AddressName {get; set; } 
[ApiMember(Name = "NewAddressName", Description = "New address name", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String NewAddressName {get; set; } 
[ApiMember(Name = "AutoReceiveCurrency", Description = "Auto convert to fiat currency on deposit", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String AutoReceiveCurrency {get; set; } 
}
}

