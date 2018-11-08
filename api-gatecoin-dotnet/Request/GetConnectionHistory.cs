using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Auth/ConnectionHistory", "GET", Summary = @"Gets connection history of logged in user", Notes = @"")]
    public class GetConnectionHistory : IReturn<ConnectionHistoryResponse>
    {
    }
}