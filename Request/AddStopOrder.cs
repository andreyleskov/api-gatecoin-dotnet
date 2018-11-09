using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Trade/StopOrders", "POST", Summary = @"Place a stop order at the exchange.", Notes = @"The account needs to be approved before transfer is possible.")]
public class AddStopOrder : IReturn<AddStopOrderResponse>
{
[ApiMember(Name = "Code", Description = "The code of the order of the currency pair. Ex: BTCUSD, BTCJPY etc", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String Code {get; set; } 
[ApiMember(Name = "Way", Description = "Ask or Bid", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String Way {get; set; } 
[ApiMember(Name = "Amount", Description = "Amount expressed in the first currency of the currency pair. BTCUSD - both bid and ask orders are expressed in BTC", ParameterType = "query", DataType = "decimal", IsRequired = true)]
public System.Decimal Amount {get; set; } 
[ApiMember(Name = "Price", Description = "Price expressed in the first currency of the currency pair. Ex. Regardless if you place a bid or ask BTCUSD, the price is always expressed in the price of one BTC in USD", ParameterType = "query", DataType = "decimal", IsRequired = false)]
public System.Decimal Price {get; set; } 
[ApiMember(Name = "IsTwoStep", Description = "If true, a market/limit order is placed first, with a second step StopLoss/TakeProfit", ParameterType = "query", DataType = "bool", IsRequired = true)]
public Boolean IsTwoStep {get; set; } 
[ApiMember(Name = "LowerType", Description = "Triggered or Trailing", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String LowerType {get; set; } 
[ApiMember(Name = "LowerPrice", Description = "Price when lower condition is triggered.", ParameterType = "query", DataType = "decimal", IsRequired = false)]
public System.Decimal LowerPrice {get; set; } 
[ApiMember(Name = "LowerTarget", Description = "Trigger price for Triggered type. Trailing price for Trailing", ParameterType = "query", DataType = "decimal", IsRequired = false)]
public System.Decimal LowerTarget {get; set; } 
[ApiMember(Name = "UpperType", Description = "Triggered or Trailing", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String UpperType {get; set; } 
[ApiMember(Name = "UpperPrice", Description = "Price when lower condition is triggered.", ParameterType = "query", DataType = "decimal", IsRequired = false)]
public System.Decimal UpperPrice {get; set; } 
[ApiMember(Name = "UpperTarget", Description = "Trigger price for Triggered type. Trailing price for Trailing", ParameterType = "query", DataType = "decimal", IsRequired = false)]
public System.Decimal UpperTarget {get; set; } 
[ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String ValidationCode {get; set; } 
}
}

