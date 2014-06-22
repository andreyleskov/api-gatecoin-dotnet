using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/ElectronicWallet/External/Rename/{DigiCurrency}", "PUT", Summary = @"Update the name of an external address ", Notes = @"")]
public class UpdateExternalElectronicAddress : IReturn<CommonResponse>
{
[ApiMember(Name = "DigiCurrency", Description = "Crypto-currency for the address (btc,ltc etc)", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String DigiCurrency {get; set; } 
[ApiMember(Name = "AddressName", Description = "Address name", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String AddressName {get; set; } 
[ApiMember(Name = "NewAddressName", Description = "New address name", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String NewAddressName {get; set; } 
}
}

