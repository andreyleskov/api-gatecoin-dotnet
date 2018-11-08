using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/ElectronicWallet/UserWallets/{DigiCurrency}/{AddressName}", "DELETE",
        Summary = @"Delete an external digital currency addresses related to the logged in user. ", Notes = @"")]
    public class DeleteElectronicWalletUserWallets : IReturn<CommonResponse>
    {
        [ApiMember(Name = "DigiCurrency", Description = "Crypto-currency for the address (btc,ltc etc)",
            ParameterType = "path", DataType = "string", IsRequired = true)]
        public string DigiCurrency { get; set; }

        [ApiMember(Name = "AddressName", Description = "External address name", ParameterType = "path",
            DataType = "string", IsRequired = true)]
        public string AddressName { get; set; }

        [ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string ValidationCode { get; set; }
    }
}