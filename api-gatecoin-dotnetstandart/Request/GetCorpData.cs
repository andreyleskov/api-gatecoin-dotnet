using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/CorporateData", "GET", Summary = @"Get corporate account data", Notes = @"")]
    public class GetCorpData : IReturn<CorpDataResponse>
    {
    }
}