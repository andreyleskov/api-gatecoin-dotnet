using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/ElectronicWallet/UserWallets/{DigiCurrency}", "GET",
        Summary = @"Gets all external digital currency addresses related to the logged in user by currency. ",
        Notes = @"")]
    public class GetElectronicWalletUserWalletsByCurrency : IReturn<ElectronicAddressesResponse>
    {
        [ApiMember(Name = "DigiCurrency", Description = "Crypto-currency for the address (btc,ltc etc)",
            ParameterType = "path", DataType = "string", IsRequired = false)]
        public string DigiCurrency { get; set; }
    }
}