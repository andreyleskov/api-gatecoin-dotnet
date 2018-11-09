using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Reference/Countries", "GET", Summary = @"Get the country list.", Notes = @"")]
public class GetCountries : IReturn<GetCountriesResponse>
{
}
}

