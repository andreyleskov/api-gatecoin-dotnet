using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/APIKey/APIKey", "POST", Summary = @"Create a new API key for logged in user", Notes = @"")]
public class CreateAPIKey : IReturn<CreateAPIKeyResponse>
{
[ApiMember(Name = "Purpose", Description = "The purpose of the API key", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String Purpose {get; set; } 
[ApiMember(Name = "ValidUntil", Description = "The API key valid period. Max 1 year.", ParameterType = "query", DataType = "DateTime", IsRequired = false)]
public System.DateTime ValidUntil {get; set; } 
[ApiMember(Name = "AllowInfo", Description = "Allow getting balance info", ParameterType = "query", DataType = "bool", IsRequired = false)]
public Boolean AllowInfo {get; set; } 
[ApiMember(Name = "AllowTrade", Description = "Allow placing order", ParameterType = "query", DataType = "bool", IsRequired = false)]
public Boolean AllowTrade {get; set; } 
[ApiMember(Name = "AllowWithdrawal", Description = "Allow currency withdrawal", ParameterType = "query", DataType = "bool", IsRequired = false)]
public Boolean AllowWithdrawal {get; set; } 
[ApiMember(Name = "AllowWrite", Description = "Allow write access", ParameterType = "query", DataType = "bool?", IsRequired = false)]
public Boolean? AllowWrite {get; set; } 
[ApiMember(Name = "AllowIPs", Description = "Only allowed ip can use the API key. No ip restriction if empty.", ParameterType = "query", DataType = "string[]", IsRequired = false)]
public System.String[] AllowIPs {get; set; } 
[ApiMember(Name = "TradeValidationCode", Description = "Enter trade validation code if trade validation is enabled and the api key allow trade", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String TradeValidationCode {get; set; } 
[ApiMember(Name = "WithdrawalValidationCode", Description = "Enter withdrawal validation code if withdraw validation is enabled and the api key allow withdrawal", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String WithdrawalValidationCode {get; set; } 
}
}

