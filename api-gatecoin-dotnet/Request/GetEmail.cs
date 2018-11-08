using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/Email", "GET", Summary = @"Get user email", Notes = @"")]
    public class GetEmail : IReturn<EmailResponse>
    {
    }
}