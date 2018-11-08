using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/ElectronicWallet/DepositWallets/{DigiCurrency}", "POST",
        Summary = @"Add an digital currency addresses to the logged in user. ", Notes = @"")]
    public class NewElectronicWalletDepositWallets : IReturn<AddElectronicAddressResponse>
    {
        [ApiMember(Name = "DigiCurrency", Description = "Crypto-currency for the address (btc,ltc etc)",
            ParameterType = "path", DataType = "string", IsRequired = true)]
        public string DigiCurrency { get; set; }

        [ApiMember(Name = "AddressName", Description = "Address Name", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string AddressName { get; set; }

        [ApiMember(Name = "AutoReceiveCurrency", Description = "Auto convert to national currency on deposit",
            ParameterType = "query", DataType = "string", IsRequired = false)]
        public string AutoReceiveCurrency { get; set; }

        [ApiMember(Name = "WalletType", Description = "address or hex (for Ethereum)", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string WalletType { get; set; }
    }
}