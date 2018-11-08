using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/ElectronicWallet/Transactions", "GET",
        Summary = @"Get all digital currency transactions of the logged in user", Notes = @"")]
    public class GetElectronicWalletTransactions : IReturn<ElectronicWalletTransactionsResponse>
    {
    }
}