using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Bank/Transactions", "POST",
        Summary =
            @"Request a transfer from the traders account of the logged in user. This is only available for bank account",
        Notes = @"The account transfer needs to be approved.")]
    public class AddBankAccountWithdraw : IReturn<CommonResponse>
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

        [ApiMember(Name = "Comment", Description = "Withdraw Comment", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string Comment { get; set; }

        [ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string ValidationCode { get; set; }
    }
}