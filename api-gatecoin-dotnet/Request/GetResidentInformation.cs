using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/ResidentInformation", "GET", Summary = @"Get Step2 Data", Notes = @"")]
    public class GetResidentInformation : IReturn<ResidentInformationResponse>
    {
    }
}