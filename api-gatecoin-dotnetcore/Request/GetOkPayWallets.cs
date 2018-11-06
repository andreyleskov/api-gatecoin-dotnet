using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Okpay/Wallet", "GET", Summary = @"Gets existing wallets for a trader", Notes = @"")]
    public class GetOkPayWallets : IReturn<GetOkPayWalletsResponse>
    {
    }
}