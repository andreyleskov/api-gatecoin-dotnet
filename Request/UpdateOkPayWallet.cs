using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Okpay/Wallet", "PUT", Summary = @"Update the label of existing wallet", Notes = @"")]
public class UpdateOkPayWallet : IReturn<CommonResponse>
{
[ApiMember(Name = "WalletId", Description = "Wallet Address", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String WalletId {get; set; } 
[ApiMember(Name = "Label", Description = "Existing Wallet Label", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String Label {get; set; } 
[ApiMember(Name = "NewLabel", Description = "New Wallet Label", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String NewLabel {get; set; } 
}
}

