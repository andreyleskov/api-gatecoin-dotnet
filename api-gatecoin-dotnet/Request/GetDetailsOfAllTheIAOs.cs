using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/InitialAssetOffering/Sales/", "GET", Summary = @"Gets detailed information of all the presales",
        Notes = @"")]
    public class GetIAOInfo : IReturn<SalesResponse>
    {
    }

    [Route("/preview/InitialAssetOffering/Sales/", "GET", Summary = @"Gets detailed information of all the presales",
        Notes = @"")]
    public class GetIAOInfoPreview : IReturn<SalesResponsePreview>
    {
    }
}