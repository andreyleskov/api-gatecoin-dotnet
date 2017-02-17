using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Info/ReferenceCurrency", "PUT", Summary = @"User's reference currency", Notes = @"")]
public class UpdateReferenceCurrency : IReturn<CommonResponse>
{
[ApiMember(Name = "CurrencyPair", Description = "Currency pair", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String CurrencyPair {get; set; } 
}
}

