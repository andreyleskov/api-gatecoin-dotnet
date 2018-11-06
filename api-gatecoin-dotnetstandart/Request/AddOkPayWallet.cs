using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Okpay/Wallet", "POST", Summary = @"Add a new wallet", Notes = @"")]
    public class AddOkPayWallet : IReturn<OkpayTransactionResponse>
    {
        [ApiMember(Name = "WalletId", Description = "Wallet Address", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string WalletId { get; set; }

        [ApiMember(Name = "Label", Description = "Wallet Label", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string Label { get; set; }

        [ApiMember(Name = "Password", Description = "Require password confirm to add okaypay wallet",
            ParameterType = "query", DataType = "string", IsRequired = true)]
        public string Password { get; set; }

        [ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string ValidationCode { get; set; }
    }
}