using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Bank/Transactions", "POST", Summary = @"Request a fiat withdrawal from traders account of logged in user",
        Notes = @"")]
    public class NewBankWithdrawals : IReturn<CommonResponse>
    {
        [ApiMember(Name = "BankAccountName", Description = "Nick of bank account", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string BankAccountName { get; set; }

        [ApiMember(Name = "Currency", Description = "Withdraw currency", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string Currency { get; set; }

        [ApiMember(Name = "Amount", Description = "Withdraw amount", ParameterType = "query", DataType = "decimal",
            IsRequired = true)]
        public decimal Amount { get; set; }

        [ApiMember(Name = "Comment", Description = "Withdraw comment", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string Comment { get; set; }

        [ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string ValidationCode { get; set; }
    }
}