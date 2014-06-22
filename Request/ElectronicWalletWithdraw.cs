using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/ElectronicWallet/Withdrawal/{DigiCurrency}", "POST", Summary = @"Request a transfer from the traders account to an external address. This is only available for crypto currencies.", Notes = @"")]
public class ElectronicWalletWithdraw : IReturn<CommonResponse>
{
[ApiMember(Name = "DigiCurrency", Description = "The digital currency to withdraw", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String DigiCurrency {get; set; } 
[ApiMember(Name = "AddressName", Description = "External address name", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String AddressName {get; set; } 
[ApiMember(Name = "Amount", Description = "Amount to withdraw", ParameterType = "query", DataType = "decimal", IsRequired = true)]
public System.Decimal Amount {get; set; } 
[ApiMember(Name = "TransactionFee", Description = "Transaction fee pay to miner. More transaction fee will result in faster transaction. Default 0. Max 0.01", ParameterType = "query", DataType = "decimal", IsRequired = false)]
public System.Decimal TransactionFee {get; set; } 
[ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String ValidationCode {get; set; } 
}
}

