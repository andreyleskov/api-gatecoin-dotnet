using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Reference/Countries", "GET", Summary = @"Get the country list.", Notes = @"")]
    public class GetCountries : IReturn<GetCountriesResponse>
    {
    }
}