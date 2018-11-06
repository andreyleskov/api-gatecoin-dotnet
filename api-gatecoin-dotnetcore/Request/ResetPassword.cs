using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Auth/ResetPassword", "POST", Summary = @"Reset password",
        Notes = @"Request for reset code in /Auth/ForgotPassword")]
    public class ResetPassword : IReturn<CommonResponse>
    {
        [ApiMember(Name = "UserID", Description = "User ID", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string UserID { get; set; }

        [ApiMember(Name = "ResetCode", Description = "Request code from email", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string ResetCode { get; set; }

        [ApiMember(Name = "Password", Description = "Password", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string Password { get; set; }

        [ApiMember(Name = "ConfirmPassword", Description = "Confirm password", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string ConfirmPassword { get; set; }

        [ApiMember(Name = "SecurityAnswer",
            Description = "Security answer if security question and answer are submitted", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string SecurityAnswer { get; set; }
    }
}