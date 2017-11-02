using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class QuickOrderQuote 
{
public System.String CurrencyFrom {get; set; } 
public System.String CurrencyTo {get; set; } 
public System.Decimal Amount {get; set; } 
public System.Decimal Price {get; set; } 
public System.String QuoteID {get; set; } 
public Boolean IsAmountInCurrencyFrom {get; set; } 
public System.DateTime ValidUntil {get; set; } 
}
}

