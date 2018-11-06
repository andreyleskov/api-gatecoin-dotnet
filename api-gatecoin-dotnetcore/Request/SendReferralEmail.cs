using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/Referral", "POST", Summary = @"Post a referral email", Notes = @"")]
    public class SendReferralEmail : IReturn<CommonResponse>
    {
        [ApiMember(Name = "Email", Description = "Email", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string Email { get; set; }
    }
}