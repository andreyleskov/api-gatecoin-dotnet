using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/ElectronicWallet/EthereumPreSaleKey", "POST", Summary = @"Upload ID document copy", Notes = @"")]
public class PostEthereumPreSaleKey : IReturn<CommonResponse>
{
[ApiMember(Name = "key", Description = "Document number of the uploaded document", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String Key {get; set; } 
}
}

