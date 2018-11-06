using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/Email/Verify", "POST", Summary = @"Verification email", Notes = @"")]
    public class VerifyEmail : IReturn<CommonResponse>
    {
        [ApiMember(Name = "Token", Description = "Token for verification", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string Token { get; set; }
    }
}