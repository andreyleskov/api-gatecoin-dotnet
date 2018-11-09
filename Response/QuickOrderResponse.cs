using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class QuickOrderResponse : CommonResponse
{
public System.String CurrencyFrom {get; set; } 
public System.String CurrencyTo {get; set; } 
public System.Decimal Amount {get; set; } 
public System.Decimal Price {get; set; } 
}
}

