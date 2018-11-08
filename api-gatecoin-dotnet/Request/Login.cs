using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Auth/Login", "POST", Summary = @"Trader session log in.", Notes = @"")]
    public class Login : IReturn<LoginResponse>
    {
        [ApiMember(Name = "UserName", Description = "user name / email", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string UserName { get; set; }

        [ApiMember(Name = "Password", Description = "password", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string Password { get; set; }

        [ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string ValidationCode { get; set; }

        [ApiMember(Name = "CaptchaResponse", Description = "Captcha code", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string CaptchaResponse { get; set; }
    }
}