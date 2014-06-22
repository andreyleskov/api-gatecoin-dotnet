using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/ElectronicWallet/External/Get", "GET", Summary = @"Gets all external digital currency addresses related to the logged in user. ", Notes = @"")]
public class GetExternalElectronicAddresses : IReturn<ElectronicAddressesResponse>
{
}
}

