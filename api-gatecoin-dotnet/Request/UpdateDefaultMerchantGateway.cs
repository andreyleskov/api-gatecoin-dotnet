using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Merchant/Gateway", "PUT", Summary = @"Update the settings of default gateway", Notes = @"")]
    public class UpdateDefaultMerchantGateway : IReturn<CommonResponse>
    {
        [ApiMember(Name = "Webhook", Description = "Webhook url", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string Webhook { get; set; }

        [ApiMember(Name = "ExpirySecond", Description = "Seconds before expiry", ParameterType = "query",
            DataType = "int", IsRequired = false)]
        public int ExpirySecond { get; set; }
    }
}