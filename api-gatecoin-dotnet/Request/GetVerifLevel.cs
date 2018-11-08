using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/Level", "GET", Summary = @"Get verif level of logged in user", Notes = @"")]
    public class GetVerifLevel : IReturn<VerifLevelResponse>
    {
    }
}