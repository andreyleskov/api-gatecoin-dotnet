using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/Ledger", "GET", Summary = @"Get the information for the user orders of ledger", Notes = @"")]
    public class GetRequestLedger : IReturn<CommonResponse>
    {
    }
}