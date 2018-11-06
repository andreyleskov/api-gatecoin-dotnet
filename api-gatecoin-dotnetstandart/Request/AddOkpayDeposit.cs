using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Okpay/DepositRequest", "POST", Summary = @"Deposit fiat currency through Okpay", Notes = @"")]
    public class AddOkpayDeposit : IReturn<OkpayTransactionResponse>
    {
        [ApiMember(Name = "Currency", Description = "Currency to deposit", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string Currency { get; set; }

        [ApiMember(Name = "Amount", Description = "Deposit amount", ParameterType = "query", DataType = "decimal",
            IsRequired = true)]
        public decimal Amount { get; set; }
    }
}