using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Public/StatisticHistory/{DigiCurrency}/{Typeofdata}", "GET", Summary = @"Get the historical data of a specific digital currency", Notes = @"If From or to is provded, count will be ignored.")]
public class GetStatsHisto : IReturn<GetStatsHistoResponse>
{
[ApiMember(Name = "DigiCurrency", Description = "The digital currency", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String DigiCurrency {get; set; } 
[ApiMember(Name = "Typeofdata", Description = "The type of data", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String Typeofdata {get; set; } 
[ApiMember(Name = "Count", Description = "Number of records", ParameterType = "query", DataType = "int", IsRequired = false)]
public System.Int32? Count {get; set; } 
[ApiMember(Name = "From", Description = "From time in unix timestamp", ParameterType = "query", DataType = "int", IsRequired = false)]
public System.Int64? From {get; set; } 
[ApiMember(Name = "To", Description = "To time in unix timestamp", ParameterType = "query", DataType = "int", IsRequired = false)]
public System.Int64? To {get; set; } 
}
}

