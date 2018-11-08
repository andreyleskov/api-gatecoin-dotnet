using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/DocumentID", "GET", Summary = @"Check if ID document copy uploaded", Notes = @"")]
    public class CheckDocument_ID : IReturn<Document_IDResponse>
    {
    }
}