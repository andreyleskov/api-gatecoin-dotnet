using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Auth/SecurityQuestion", "GET", Summary = @"Get security question of the user", Notes = @"")]
    public class GetSecurityQuestion : IReturn<SecurityQuestionResponse>
    {
    }
}