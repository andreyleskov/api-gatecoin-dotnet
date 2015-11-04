using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/ElectronicWallet/DepositWallets", "GET", Summary = @"Gets all crypto currency addresses related deposits to the logged in user. ", Notes = @"")]
public class GetElectronicWalletDepositWallets : IReturn<InternalElectronicAddressesResponse>
{
}
}

