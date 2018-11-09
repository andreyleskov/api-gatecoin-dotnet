using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Public/LiveTicker/{CurrencyPair}", "GET", Summary = @"Get live ticker by currency", Notes = @"")]
public class GetTicker : IReturn<TickerResponse>
{
[ApiMember(Name = "CurrencyPair", Description = "Currency Pair", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String CurrencyPair {get; set; } 
}
}

