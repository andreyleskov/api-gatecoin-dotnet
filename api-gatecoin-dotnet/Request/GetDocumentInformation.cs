using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/DocumentInformation", "GET", Summary = @"Get Step3 Data", Notes = @"")]
    public class GetDocumentInformation : IReturn<DocumentInformationResponse>
    {
    }
}