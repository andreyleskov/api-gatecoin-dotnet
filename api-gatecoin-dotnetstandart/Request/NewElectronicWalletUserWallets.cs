using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/ElectronicWallet/UserWallets/{DigiCurrency}", "POST",
        Summary = @"Add an external digital currency addresses to the logged in user. ", Notes = @"")]
    public class NewElectronicWalletUserWallets : IReturn<CommonResponse>
    {
        [ApiMember(Name = "DigiCurrency", Description = "Crypto-currency for the address (btc,ltc etc)",
            ParameterType = "path", DataType = "string", IsRequired = true)]
        public string DigiCurrency { get; set; }

        [ApiMember(Name = "AddressName", Description = "Address Name", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string AddressName { get; set; }

        [ApiMember(Name = "Address", Description = "Public address of wallet", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string Address { get; set; }

        [ApiMember(Name = "Password", Description = "Require password confirm to add external address",
            ParameterType = "query", DataType = "string", IsRequired = true)]
        public string Password { get; set; }

        [ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string ValidationCode { get; set; }
    }
}