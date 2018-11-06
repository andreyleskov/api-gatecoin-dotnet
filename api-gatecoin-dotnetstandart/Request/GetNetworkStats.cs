using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Public/NetworkStatistics/{DigiCurrency}", "GET",
        Summary = @"Get the network status of a specific digital currency", Notes = @"")]
    public class GetNetworkStats : IReturn<GetNetworkStatsResponse>
    {
        [ApiMember(Name = "DigiCurrency", Description = "The digital currency", ParameterType = "path",
            DataType = "string", IsRequired = false)]
        public string DigiCurrency { get; set; }
    }
}