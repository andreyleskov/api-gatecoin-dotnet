using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/ElectronicWallet/UserWallets/{DigiCurrency}", "PUT", Summary = @"Update the name of an external address ",
        Notes = @"")]
    public class UpdateElectronicWalletUserWallets : IReturn<CommonResponse>
    {
        [ApiMember(Name = "DigiCurrency", Description = "Crypto-currency for the address (btc,ltc etc)",
            ParameterType = "path", DataType = "string", IsRequired = true)]
        public string DigiCurrency { get; set; }

        [ApiMember(Name = "AddressName", Description = "Address name", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string AddressName { get; set; }

        [ApiMember(Name = "NewAddressName", Description = "New address name", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string NewAddressName { get; set; }
    }
}