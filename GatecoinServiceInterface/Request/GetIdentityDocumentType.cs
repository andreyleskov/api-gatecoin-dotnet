using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Reference/IdentydocumentTypes", "GET", Summary = @"Get the different types of identity documents possible.", Notes = @"")]
public class GetIdentityDocumentType : IReturn<GetIdentityDocumentTypeResponse>
{
}
}

