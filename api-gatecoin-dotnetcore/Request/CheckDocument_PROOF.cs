using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/DocumentAddress", "GET", Summary = @"Check if residence proof uploaded", Notes = @"")]
    public class CheckDocument_PROOF : IReturn<Document_PROOFResponse>
    {
    }
}