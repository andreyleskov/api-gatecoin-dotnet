using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Public/StatsHisto/{DigiCurrency}/{Typeofdata}", "GET", Summary = @"Get the historical data of a specific digital currency", Notes = @"")]
public class GetStatsHisto : IReturn<GetStatsHistoResponse>
{
[ApiMember(Name = "DigiCurrency", Description = "The digital currency", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String DigiCurrency {get; set; } 
[ApiMember(Name = "Typeofdata", Description = "The type of data", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String Typeofdata {get; set; } 
[ApiMember(Name = "Count", Description = "Number of records", ParameterType = "query", DataType = "int", IsRequired = true)]
public Int32 Count {get; set; } 
}
}

