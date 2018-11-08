using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/APIKey/APIKey/{PublicKey}", "DELETE", Summary = @"Remove an API key", Notes = @"")]
    public class DeleteAPIKey : IReturn<CommonResponse>
    {
        [ApiMember(Name = "PublicKey", Description = "The public key of API key to delete", ParameterType = "path",
            DataType = "string", IsRequired = true)]
        public string PublicKey { get; set; }
    }
}