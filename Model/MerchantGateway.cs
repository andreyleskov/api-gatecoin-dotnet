using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class MerchantGateway 
{
public System.String Label {get; set; }
public System.Int32 MinConfirmation { get; set; }
public System.Int32 ExpirySecond { get; set; }
public System.String Webhook {get; set; } 
public System.String GatewayType {get; set; } 
public System.String Currency {get; set; } 
}
}