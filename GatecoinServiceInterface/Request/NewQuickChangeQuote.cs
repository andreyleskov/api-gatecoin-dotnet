using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Trade/QuickChange/Quote", "POST", Summary = @"Request a quote for quick order", Notes = @"")]
public class NewQuickChangeQuote : IReturn<RequestForQuoteResponse>
{
[ApiMember(Name = "CurrencyFrom", Description = "Request for quote from currency, Ex: USD, HKD, BTC", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String CurrencyFrom {get; set; } 
[ApiMember(Name = "CurrencyTo", Description = "Request for quote to currency, Ex: USD, HKD, BTC", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String CurrencyTo {get; set; } 
[ApiMember(Name = "Amount", Description = "Amount expressed in the currency From if not specified", ParameterType = "query", DataType = "decimal", IsRequired = true)]
public System.Decimal Amount {get; set; } 
[ApiMember(Name = "IsAmountInCurrencyFrom", Description = "Indicate whether the amount in currency from", ParameterType = "query", DataType = "bool", IsRequired = false)]
public System.Boolean? IsAmountInCurrencyFrom {get; set; } 
}
}

