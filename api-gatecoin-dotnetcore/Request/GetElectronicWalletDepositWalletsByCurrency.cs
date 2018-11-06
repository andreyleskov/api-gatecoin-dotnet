using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/ElectronicWallet/DepositWallets/{DigiCurrency}", "GET",
        Summary = @"Gets all crypto currency addresses related deposits to the logged in user by currency. ",
        Notes = @"")]
    public class GetElectronicWalletDepositWalletsByCurrency : IReturn<InternalElectronicAddressesResponse>
    {
        [ApiMember(Name = "DigiCurrency", Description = "Crypto-currency for the address (btc,ltc etc)",
            ParameterType = "path", DataType = "string", IsRequired = false)]
        public string DigiCurrency { get; set; }
    }
}