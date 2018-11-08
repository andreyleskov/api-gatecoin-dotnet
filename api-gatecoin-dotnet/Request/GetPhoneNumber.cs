using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/Phone", "GET", Summary = @"Get user phone number", Notes = @"")]
    public class GetPhoneNumber : IReturn<PhoneNumberResponse>
    {
    }
}