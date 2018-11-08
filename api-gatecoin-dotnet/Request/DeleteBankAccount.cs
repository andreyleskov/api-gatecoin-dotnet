using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Bank/UserAccounts/{Currency}/{Label}", "DELETE", Summary = @"Delete an account of the logged in user",
        Notes = @"")]
    public class DeleteBankAccount : IReturn<CommonResponse>
    {
        [ApiMember(Name = "Currency", Description = "Currency of the bank account", ParameterType = "path",
            DataType = "string", IsRequired = true)]
        public string Currency { get; set; }

        [ApiMember(Name = "Label", Description = "Bank account label (for use on Gatecoin website only)",
            ParameterType = "path", DataType = "string", IsRequired = true)]
        public string Label { get; set; }

        [ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string ValidationCode { get; set; }
    }
}