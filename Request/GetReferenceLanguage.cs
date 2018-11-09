using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Info/ReferenceLanguage", "GET", Summary = @"Get user's reference language", Notes = @"")]
public class GetReferenceLanguage : IReturn<ReferenceLanguageResponse>
{
}
}

