using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Merchant/Gateway/{Label}", "PUT", Summary = @"Update the settings of a specific gateway", Notes = @"")]
    public class UpdateMerchantGateway : IReturn<CommonResponse>
    {
        [ApiMember(Name = "Label", Description = "Label", ParameterType = "path", DataType = "string",
            IsRequired = false)]
        public string Label { get; set; }

        [ApiMember(Name = "Webhook", Description = "Webhook url", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string Webhook { get; set; }

        [ApiMember(Name = "ExpirySecond", Description = "Seconds before expiry", ParameterType = "query",
            DataType = "int", IsRequired = false)]
        public int ExpirySecond { get; set; }
    }
}