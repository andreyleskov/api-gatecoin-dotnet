using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/DocumentCorporation", "GET", Summary = @"Check if registered document uploaded", Notes = @"")]
public class CheckDocument_Registered : IReturn<Document_RegisteredResponse>
{
}
}

