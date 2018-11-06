using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/ElectronicWallet/DepositWallets", "GET",
        Summary = @"Gets all crypto currency addresses related deposits to the logged in user. ", Notes = @"")]
    public class GetElectronicWalletDepositWallets : IReturn<InternalElectronicAddressesResponse>
    {
    }
}