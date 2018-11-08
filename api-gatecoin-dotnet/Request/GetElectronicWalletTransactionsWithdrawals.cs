using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/ElectronicWallet/Transactions/Withdrawals/{DigiCurrency}", "POST",
        Summary = @"Get all external digital currency transactions of the logged in user", Notes = @"")]
    public class GetElectronicWalletTransactionsWithdrawals : IReturn<ElectronicWalletTransactionsResponse>
    {
        [ApiMember(Name = "DigiCurrency", Description = "The digital currency to check", ParameterType = "path",
            DataType = "string", IsRequired = false)]
        public string DigiCurrency { get; set; }

        [ApiMember(Name = "AddressName", Description = "External address name", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string AddressName { get; set; }
    }
}