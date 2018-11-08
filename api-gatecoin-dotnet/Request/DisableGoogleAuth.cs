using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/DisableGoogleAuth", "POST", Summary = @"Disable google auth", Notes = @"")]
    public class DisableGoogleAuth : IReturn<CommonResponse>
    {
        [ApiMember(Name = "Password", Description = "Require password confirmation to disable google auth",
            ParameterType = "query", DataType = "string", IsRequired = true)]
        public string Password { get; set; }

        [ApiMember(Name = "AuthCode", Description = "The code shown on authentication device", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string AuthCode { get; set; }
    }
}