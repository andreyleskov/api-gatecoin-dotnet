using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Reference/IdentydocumentTypes", "GET",
        Summary = @"Get the different types of identity documents possible.", Notes = @"")]
    public class GetIdentityDocumentType : IReturn<GetIdentityDocumentTypeResponse>
    {
    }
}