using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Merchant/Gateway/{Label}", "PUT", Summary = @"Update the settings of a specific gateway", Notes = @"")]
public class UpdateMerchantGateway : IReturn<CommonResponse>
{
[ApiMember(Name = "Label", Description = "Label", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String Label {get; set; } 
[ApiMember(Name = "Webhook", Description = "Webhook url", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String Webhook {get; set; } 
[ApiMember(Name = "ExpirySecond", Description = "Seconds before expiry", ParameterType = "query", DataType = "int", IsRequired = false)]
public Int32 ExpirySecond {get; set; } 
}
}

