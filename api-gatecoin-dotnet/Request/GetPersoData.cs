using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/PersonalData", "GET", Summary = @"Get user personal data", Notes = @"")]
    public class GetPersoData : IReturn<PersoDataResponse>
    {
    }
}