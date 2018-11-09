using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Reference/VerificationLevelList", "GET", Summary = @"Get the verif level list.", Notes = @"")]
public class GetVerificationLevelList : IReturn<ReferenceListResponse>
{
}
}

