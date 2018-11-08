using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/DocumentCorporation", "GET", Summary = @"Check if registered document uploaded", Notes = @"")]
    public class CheckDocument_Registered : IReturn<Document_RegisteredResponse>
    {
    }
}