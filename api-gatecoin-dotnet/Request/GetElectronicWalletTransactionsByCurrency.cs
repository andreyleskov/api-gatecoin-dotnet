using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/ElectronicWallet/Transactions/{DigiCurrency}", "GET",
        Summary = @"Get all digital currency transactions of the logged in user", Notes = @"")]
    public class GetElectronicWalletTransactionsByCurrency : IReturn<ElectronicWalletTransactionsResponse>
    {
        [ApiMember(Name = "DigiCurrency", Description = "The digital currency to check", ParameterType = "path",
            DataType = "string", IsRequired = false)]
        public string DigiCurrency { get; set; }
    }
}