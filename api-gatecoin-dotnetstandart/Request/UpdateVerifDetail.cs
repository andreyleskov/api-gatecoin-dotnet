using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/SecuritySettings", "PUT", Summary = @"Update verif details of logged in user", Notes = @"")]
    public class UpdateVerifDetail : IReturn<VerifDetailResponse>
    {
        [ApiMember(Name = "LoginWarning", Description = "Receive email warning for login", ParameterType = "query",
            DataType = "bool", IsRequired = true)]
        public bool LoginWarning { get; set; }

        [ApiMember(Name = "LoginValidation",
            Description = "Require validation for login (none = 0, 1 = email, 2 = google auth, 3 = sms)",
            ParameterType = "query", DataType = "int", IsRequired = true)]
        public int LoginValidation { get; set; }

        [ApiMember(Name = "TradeWarning", Description = "Receive email warning for trade", ParameterType = "query",
            DataType = "bool", IsRequired = true)]
        public bool TradeWarning { get; set; }

        [ApiMember(Name = "TradeValidation",
            Description = "Require validation for trade (none = 0, 1 = email, 2 = google auth, 3 = sms)",
            ParameterType = "query", DataType = "int", IsRequired = true)]
        public int TradeValidation { get; set; }

        [ApiMember(Name = "WithdrawValidation",
            Description = "Require validation for withdraw (none = 0, 1 = email, 2 = google auth, 3 = sms)",
            ParameterType = "query", DataType = "int", IsRequired = true)]
        public int WithdrawValidation { get; set; }

        [ApiMember(Name = "AddAccountValidation",
            Description =
                "Require validation for adding bank account and external electronic address (none = 0, 1 = email, 2 = google auth, 3 = sms)",
            ParameterType = "query", DataType = "int", IsRequired = true)]
        public int AddAccountValidation { get; set; }

        [ApiMember(Name = "ChangeDetailsValidation",
            Description = "Require validation for changing details (none = 0, 1 = email, 2 = google auth, 3 = sms)",
            ParameterType = "query", DataType = "int", IsRequired = true)]
        public int ChangeDetailsValidation { get; set; }

        [ApiMember(Name = "ChangePasswordValidation",
            Description = "Require validation for changing password (none = 0, 1 = email, 2 = google auth, 3 = sms)",
            ParameterType = "query", DataType = "int", IsRequired = true)]
        public int ChangePasswordValidation { get; set; }

        [ApiMember(Name = "Password", Description = "Require password confirm to change security settings",
            ParameterType = "query", DataType = "string", IsRequired = true)]
        public string Password { get; set; }

        [ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string ValidationCode { get; set; }
    }
}