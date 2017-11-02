using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class MerchantQuoteResponse : CommonResponse
{
public System.String Address {get; set; } 
public System.Decimal Price {get; set; } 
public System.Decimal Amount {get; set; } 
public System.String TxID {get; set; } 
}
}

