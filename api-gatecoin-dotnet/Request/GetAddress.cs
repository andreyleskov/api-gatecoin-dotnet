using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/Address", "GET", Summary = @"Get user address", Notes = @"")]
    public class GetAddress : IReturn<AddressResponse>
    {
    }
}