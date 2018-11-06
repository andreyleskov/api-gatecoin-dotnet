using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/APIKey/APIKey", "GET", Summary = @"Get API Key for logged in user", Notes = @"")]
    public class GetAPIKey : IReturn<GetAPIKeyResponse>
    {
    }
}