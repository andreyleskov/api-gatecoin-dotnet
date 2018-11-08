using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/PersonalInformation", "GET", Summary = @"Get Step1 Data", Notes = @"")]
    public class GetPersonalInformation : IReturn<PersonalInformationResponse>
    {
    }
}