using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/Name", "GET", Summary = @"Get user name", Notes = @"")]
    public class GetName : IReturn<NameResponse>
    {
    }
}