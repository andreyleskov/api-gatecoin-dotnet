using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Public/NetworkStatistics/{DigiCurrency}", "GET", Summary = @"Get the network status of a specific digital currency", Notes = @"")]
public class GetNetworkStats : IReturn<GetNetworkStatsResponse>
{
[ApiMember(Name = "DigiCurrency", Description = "The digital currency", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String DigiCurrency {get; set; } 
}
}

