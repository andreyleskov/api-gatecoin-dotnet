using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Export/Transactions", "POST", Summary = @"Request a export of all trades from based on currencypair, start date and end date", Notes = @"")]
public class ExportTrades : IReturn<ExportResponse>
{
[ApiMember(Name = "CurrencyPair", Description = "Transactions currency", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String CurrencyPair {get; set; } 
[ApiMember(Name = "Currency", Description = "Transactions currency", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String Currency {get; set; } 
[ApiMember(Name = "DateFrom", Description = "Start Date", ParameterType = "query", DataType = "datetime", IsRequired = true)]
public System.DateTime DateFrom {get; set; } 
[ApiMember(Name = "DateTo", Description = "End Date", ParameterType = "query", DataType = "datetime", IsRequired = true)]
public System.DateTime DateTo {get; set; } 
}
}

