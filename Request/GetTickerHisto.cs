using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Public/TickerHistory/{CurrencyPair}/{Timeframe}", "GET", Summary = @"Get ticker history", Notes = @"Max return 100 record")]
public class GetTickerHisto : IReturn<HistoTickersResponse>
{
[ApiMember(Name = "CurrencyPair", Description = "Currency Pair", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String CurrencyPair {get; set; } 
[ApiMember(Name = "Timeframe", Description = "Timeframe (1m,15m,1h,6h,24h)", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String Timeframe {get; set; } 
[ApiMember(Name = "Count", Description = "Number of tickers", ParameterType = "query", DataType = "int", IsRequired = false)]
public Int32 Count {get; set; } 
}
}

