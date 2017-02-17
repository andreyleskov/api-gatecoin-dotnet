using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/DocumentID", "GET", Summary = @"Check if ID document copy uploaded", Notes = @"")]
public class CheckDocument_ID : IReturn<Document_IDResponse>
{
}
}

