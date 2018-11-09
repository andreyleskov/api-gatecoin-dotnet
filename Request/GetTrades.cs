using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/{CurrencyPair}/Trades", "GET", Summary = @"Gets all trades", Notes = @"")]
public class GetTrades : IReturn<TradesResponse>
{
[ApiMember(Name = "CurrencyPair", Description = "Currency Pair", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String CurrencyPair {get; set; } 
[ApiMember(Name = "Since", Description = "Get trades from specific tid", ParameterType = "query", DataType = "long", IsRequired = false)]
public System.Int64? Since {get; set; } 
}
}

