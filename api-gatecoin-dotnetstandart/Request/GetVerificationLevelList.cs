using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Reference/VerificationLevelList", "GET", Summary = @"Get the verif level list.", Notes = @"")]
    public class GetVerificationLevelList : IReturn<ReferenceListResponse>
    {
    }
}