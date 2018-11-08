using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/GoogleAuth", "POST", Summary = @"Enable google auth", Notes = @"Return QRCode in base64 string")]
    public class EnableGoogleAuth : IReturn<EnableGoogleAuthResponse>
    {
        [ApiMember(Name = "IsEnable", Description = "Enable or disable google auth", ParameterType = "query",
            DataType = "bool", IsRequired = true)]
        public bool IsEnable { get; set; }

        [ApiMember(Name = "Password", Description = "Require password confirmation to disable google auth",
            ParameterType = "query", DataType = "string", IsRequired = false)]
        public string Password { get; set; }

        [ApiMember(Name = "AuthCode", Description = "The code shown on authentication device", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string AuthCode { get; set; }
    }
}