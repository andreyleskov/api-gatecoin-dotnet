using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/ElectronicWallet/EthereumPreSaleKey", "POST", Summary = @"Upload ID document copy", Notes = @"")]
    public class PostEthereumPreSaleKey : IReturn<CommonResponse>
    {
        [ApiMember(Name = "key", Description = "Document number of the uploaded document", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string Key { get; set; }
    }
}