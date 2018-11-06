using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Okpay/Wallet", "PUT", Summary = @"Update the label of existing wallet", Notes = @"")]
    public class UpdateOkPayWallet : IReturn<CommonResponse>
    {
        [ApiMember(Name = "WalletId", Description = "Wallet Address", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string WalletId { get; set; }

        [ApiMember(Name = "Label", Description = "Existing Wallet Label", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string Label { get; set; }

        [ApiMember(Name = "NewLabel", Description = "New Wallet Label", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string NewLabel { get; set; }
    }
}