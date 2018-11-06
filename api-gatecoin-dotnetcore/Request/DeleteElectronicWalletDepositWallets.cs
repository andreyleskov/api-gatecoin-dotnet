using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/ElectronicWallet/DepositWallets/{DigiCurrency}/{AddressName}", "DELETE",
        Summary = @"Delete an digital currency addresses related to the logged in user. ", Notes = @"")]
    public class DeleteElectronicWalletDepositWallets : IReturn<CommonResponse>
    {
        [ApiMember(Name = "DigiCurrency", Description = "Crypto-currency for the address (btc,ltc etc)",
            ParameterType = "path", DataType = "string", IsRequired = true)]
        public string DigiCurrency { get; set; }

        [ApiMember(Name = "AddressName", Description = "Address name", ParameterType = "path", DataType = "string",
            IsRequired = true)]
        public string AddressName { get; set; }
    }
}