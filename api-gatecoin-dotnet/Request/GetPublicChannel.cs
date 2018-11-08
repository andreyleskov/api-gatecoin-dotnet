using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Stream/PublicChannel", "GET", Summary = @"Get the public pubnub channel list", Notes = @"")]
    public class GetPublicChannel : IReturn<PublicChannelResponse>
    {
    }
}