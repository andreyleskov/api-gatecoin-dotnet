using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Auth/ForgotPassword", "POST", Summary = @"Request reset password", Notes = @"")]
    public class ForgotPassword : IReturn<CommonResponse>
    {
        [ApiMember(Name = "UserID", Description = "User ID", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string UserID { get; set; }

        [ApiMember(Name = "Email", Description = "Registration email", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string Email { get; set; }
    }
}