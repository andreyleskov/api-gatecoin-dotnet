using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/ElectronicWallet/DepositWallets/{DigiCurrency}/{AddressName}", "PUT",
        Summary = @"Update the name of an address ", Notes = @"")]
    public class UpdateElectronicWalletDepositWallets : IReturn<CommonResponse>
    {
        [ApiMember(Name = "DigiCurrency", Description = "Crypto-currency for the address (btc,ltc etc)",
            ParameterType = "path", DataType = "string", IsRequired = true)]
        public string DigiCurrency { get; set; }

        [ApiMember(Name = "AddressName", Description = "Address name", ParameterType = "path", DataType = "string",
            IsRequired = true)]
        public string AddressName { get; set; }

        [ApiMember(Name = "NewAddressName", Description = "New address name", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string NewAddressName { get; set; }

        [ApiMember(Name = "AutoReceiveCurrency", Description = "Auto convert to fiat currency on deposit",
            ParameterType = "query", DataType = "string", IsRequired = false)]
        public string AutoReceiveCurrency { get; set; }
    }
}