using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/ElectronicWallet/UserWallets", "GET", Summary = @"Gets all external digital currency addresses related to the logged in user. ", Notes = @"")]
public class GetElectronicWalletUserWallets : IReturn<ElectronicAddressesResponse>
{
}
}

