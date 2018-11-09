using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/DocumentAddress", "GET", Summary = @"Check if residence proof uploaded", Notes = @"")]
public class CheckDocument_PROOF : IReturn<Document_PROOFResponse>
{
}
}

