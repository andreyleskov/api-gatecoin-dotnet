using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Okpay/Withdrawal", "POST", Summary = @"Withdraw flat currency through Okpay", Notes = @"")]
    public class AddOkpayWithdrawal : IReturn<OkpayTransactionResponse>
    {
        [ApiMember(Name = "Currency", Description = "Currency to withdraw", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string Currency { get; set; }

        [ApiMember(Name = "Amount", Description = "Withdrawal amount", ParameterType = "query", DataType = "decimal",
            IsRequired = true)]
        public decimal Amount { get; set; }

        [ApiMember(Name = "WalletId", Description = "OkPay Wallet Id", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string WalletId { get; set; }

        [ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string ValidationCode { get; set; }
    }
}