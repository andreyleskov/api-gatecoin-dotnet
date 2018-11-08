using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Info/ReferenceLanguage", "GET", Summary = @"Get user's reference language", Notes = @"")]
    public class GetReferenceLanguage : IReturn<ReferenceLanguageResponse>
    {
    }
}