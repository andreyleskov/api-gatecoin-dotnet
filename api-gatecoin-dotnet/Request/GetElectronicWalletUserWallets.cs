using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/ElectronicWallet/UserWallets", "GET",
        Summary = @"Gets all external digital currency addresses related to the logged in user. ", Notes = @"")]
    public class GetElectronicWalletUserWallets : IReturn<ElectronicAddressesResponse>
    {
    }
}